using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameCaroAI.Classes;
using GameCaroAI.Option;
using Guna.UI2.WinForms;

namespace GameCaroAI.GUI
{
    public partial class FrmAI : Form
    {
        DataProcesser dtBase = new DataProcesser();
        public int levelAI;
        public const int MAX_DEPTH = 5;
        public bool isYourTurn = true; 
        public bool isComputerTurn = true;
        public int xFirstMoveRow;
        public int xFirstMoveCol;
        public int xCount = 0;
        public int comCount = 0;
        public string[,] board = new string[Helpers.CHESS_BOARD_HEIGHT, Helpers.CHESS_BOARD_WIDTH];
        public int timeLeft;
        public Stack<Move> undoStack = new Stack<Move>();
        public Stack<Move> redoStack = new Stack<Move>();
        public EasyOption easyOption;
        public MediumOption mediumOption;
        public HardOption hardOption;
        public string playerID = "";
        public FrmAI(int level)
        {
            InitializeComponent();
            DrawCaroBoard();
            levelAI = level;
            InitializeAI(levelAI);
            string sqlPlayer = "select PlayerID from Player where Username = @Username";
            Dictionary<string, object> param = new Dictionary<string, object>()
            {
                {"@Username", PlayerInfo.Username }
            };
            DataTable dtPlayer = dtBase.SearchData(sqlPlayer, param);
            if (dtPlayer.Rows.Count > 0)
            {
                playerID = dtPlayer.Rows[0]["PlayerID"].ToString(); ;
            }
            this.lb_player.Text = "Người chơi: "+PlayerInfo.Username;
            WinLoseCount();
        }
        private void InitializeAI(int level)
        {
            if (level == 0)
            {
                easyOption = new EasyOption(board);
                lbl_level.Text = "Mức độ: Dễ";
            }
            else if (level == 1) 
            {
                mediumOption = new MediumOption(board, MAX_DEPTH);
                lbl_level.Text = "Mức độ: Trung Bình";
            }
            else if (level == 2)
            {
                hardOption = new HardOption(board, MAX_DEPTH);
                lbl_level.Text = "Mức độ: Khó";
            }
        }
        public void WinLoseCount()
        {
            string sqlWinCount = "Select count(PlayerID) as WinCount " +
                            "from Game " +
                            "where PlayerID = @PlayerID and result = N'Win'";
            Dictionary<string, object> paramWinCount = new Dictionary<string, object>
            {
                {"@PlayerID", playerID},
            };
            DataTable dtWin = dtBase.SearchData(sqlWinCount, paramWinCount);
            int winCount = Convert.ToInt32(dtWin.Rows[0]["WinCount"]);
            lb_winCount.Text = $"Số trận thắng: {winCount}";

            string sqlLoseCount = "Select count(PlayerID) as LoseCount " +
                                  "from Game " +
                                  "where PlayerID = @PlayerID and result = N'Lose'";
            Dictionary<string, object> paramLoseCount = new Dictionary<string, object>
            {
                {"@PlayerID", playerID},
            };
            DataTable dtLose = dtBase.SearchData(sqlLoseCount, paramLoseCount);
            int loseCount = Convert.ToInt32(dtLose.Rows[0]["LoseCount"]);
            lb_loseCount.Text = $"Số trận thua: {loseCount}";
        }
        public void saveGameResult(string result)
        {
            if (!string.IsNullOrEmpty(playerID))
            {
                string newGameID = dtBase.GenerateGameID();
                string sqlInsert = "Insert into Game (GameID, PlayerID, Score, Result, GameStatus, CreateAt)" +
                                   "values (@GameID, @PlayerID, @Score, @Result, @GameStatus, getdate())";
                Dictionary<string, object> parameters = new Dictionary<string, object>()
                {
                    {"@GameID", newGameID},
                    {"@PlayerID", playerID},
                    {"@Score", xCount.ToString()}, 
                    {"@Result", result},
                    {"@GameStatus", 1} 
                };
                if (dtBase.ChangeData(sqlInsert, parameters))
                {
                    MessageBox.Show($"YOU {result.ToUpper()}! Kết quả trận đấu đã được lưu lại");
                }
                else
                {
                    MessageBox.Show("Lỗi lưu kết quả trận đấu");
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Guna2ButtonWithPosition btn = sender as Guna2ButtonWithPosition;
            if (btn != null && btn.BackgroundImage == null) 
            {
                int row = btn.Location.Y / Helpers.CHESS_HEIGHT;
                int col = btn.Location.X / Helpers.CHESS_WIDTH;
                if (isYourTurn)
                {
                    string imagePath = Path.Combine(Application.StartupPath, "Assess\\Images\\X.png");
                    btn.BackgroundImage = Image.FromFile(imagePath);
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    board[row, col] = "X";
                    xCount++;
                    lbl_You.Text ="X (You): " + xCount.ToString();
                    if (CheckWinner(row, col))
                    {
                        MessageBox.Show("YOU WINS!");
                        saveGameResult("Win");
                        return;
                    }
                    xFirstMoveRow = row;
                    xFirstMoveCol = col;

                    undoStack.Push(new Move(row, col, "X"));
                    redoStack.Clear();

                    isYourTurn = false;
                    isComputerTurn = true;

                    MachinePlayO();
                }
            }
        }

        public void MachinePlayO()
        {
            if(isComputerTurn)
            {
                // Nước đi đầu
                if (xCount == 1 && comCount == 0)
                {
                    int row, col;
                    // Góc trên cùng bên phải
                    if (xFirstMoveRow == 0 && xFirstMoveCol == Helpers.CHESS_BOARD_WIDTH - 1)
                    {
                        // Đánh vào góc dưới bên trái
                        row = xFirstMoveRow + 1;
                        col = xFirstMoveCol - 1;
                    }
                    // Góc dưới cùng bên trái
                    else if (xFirstMoveRow == Helpers.CHESS_BOARD_HEIGHT - 1 && xFirstMoveCol == 0)
                    {
                        // Đánh vào góc trên bên phải
                        row = xFirstMoveRow - 1;
                        col = xFirstMoveCol + 1;
                    }
                    // Góc trên cùng bên trái của bàn cờ
                    else if (xFirstMoveRow == 0 && xFirstMoveCol == 0)
                    {
                        // Đánh vào góc dưới bên phải
                        row = xFirstMoveRow + 1;
                        col = xFirstMoveCol + 1;
                    }
                    // Góc dưới cùng bên phải
                    else if (xFirstMoveRow == Helpers.CHESS_BOARD_HEIGHT - 1 && xFirstMoveCol == Helpers.CHESS_BOARD_WIDTH - 1)
                    {
                        // Đánh vào góc trên bên trái
                        row = xFirstMoveRow - 1;
                        col = xFirstMoveCol - 1;
                    }
                    // Biên trên cùng bàn cờ
                    else if (xFirstMoveRow == 0)
                    {
                        // Đánh vào góc dưới bên phải
                        row = xFirstMoveRow + 1;
                        col = xFirstMoveCol + 1;
                    }
                    // Biên bên trái của bàn cờ
                    else if (xFirstMoveCol == 0)
                    {
                        // Đánh vào góc trên bên phải
                        row = xFirstMoveRow - 1;
                        col = xFirstMoveCol + 1;
                    }
                    // Biên bên phải bàn cờ
                    else if (xFirstMoveCol == Helpers.CHESS_BOARD_WIDTH - 1)
                    {
                        // Đánh vào góc trên bên trái
                        row = xFirstMoveRow - 1;
                        col = xFirstMoveCol - 1;
                    }
                    // Biên dưới cùng bàn cờ
                    else if (xFirstMoveRow == Helpers.CHESS_BOARD_HEIGHT - 1)
                    {
                        // Đánh vào góc trên bên trái
                        row = xFirstMoveRow - 1;
                        col = xFirstMoveCol - 1;
                    }
                    else
                    {
                        // Đánh vào góc chéo bên trái của nước đầu tiên của X
                        row = xFirstMoveRow - 1;
                        col = xFirstMoveCol - 1;
                    }
                    while (board[row, col] != null)
                    {
                        row++;
                        col++;
                    }
                    UpdateBoard(row, col);
                }
                else
                {
                    if (levelAI == 0)
                    {
                        int[] move = easyOption.findMove();
                        int row, col;
                        do
                        {
                            row = move[0]; 
                            col = move[1];   
                        } while (board[row, col] != null);
                        UpdateBoard(row, col);
                    }
                    else if(levelAI == 1)
                    {
                        int[] move = mediumOption.findBestMove();
                        int row, col;
                        do
                        {
                            row = move[0];
                            col = move[1];
                        } while (board[row, col] != null);

                        UpdateBoard(row, col);
                    }   
                    else if (levelAI == 2)
                    {
                        int[] move = hardOption.findBestMove();
                        int row, col;
                        do
                        {
                            row = move[0];
                            col = move[1];
                        } while (board[row, col] != null);

                        UpdateBoard(row, col);
                    }
                }
            }
        }

        public void UpdateBoard(int row, int col)
        {
            foreach (Control c in pn_ChessBoard.Controls)
            {
                if (c is Guna2ButtonWithPosition btn && btn.Row == row && btn.Col == col)
                {
                    string imagePath = Path.Combine(Application.StartupPath, "Assess\\Images\\O.png");
                    btn.BackgroundImage = Image.FromFile(imagePath);
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    board[row, col] = "O";
                    comCount++;
                    lbl_Computer.Text = "O (Computer): " + comCount.ToString();
                    if (CheckWinner(row, col))
                    {
                        MessageBox.Show("COMPUTER WINS!");
                        saveGameResult("Lose");
                        return;
                    }
                    undoStack.Push(new Move(row, col, "O"));
                    redoStack.Clear();

                    isYourTurn = true;
                    isComputerTurn = false; 
                }
            }
            StartCountdown(60);
        }
      
        public bool CheckWinner(int row, int col)
        {
            string player = isYourTurn ? "X" : "O";
            // Kiểm tra hàng ngang
            for (int i = 0; i < Helpers.CHESS_BOARD_WIDTH-4; i++)
            {
                bool win = true;
                for (int j = 0; j < 5; j++)
                {
                    if (board[row, i + j] != player)
                    {
                        win = false; 
                        break;
                    }
                }
                if (win) return true;
            }

            // Kiểm tra hàng dọc
            for (int i = 0; i < Helpers.CHESS_BOARD_HEIGHT-4; i++)
            {
                bool win = true;
                for (int j = 0; j < 5; j++)
                {
                    if (board[i+j, col] != player)
                    {
                        win = false;
                        break;
                    }
                }
                if (win) return true;
            }

            // Kiểm tra đường chéo chính
            for (int i = -4; i <= 0; i++)
            {
                bool win = true;
                for (int j = 0; j < 5; j++)
                {
                    int checkRow = row + i + j;
                    int checkCol = col + i + j;
                    if (checkRow < 0 || checkRow >= Helpers.CHESS_BOARD_HEIGHT ||
                        checkCol < 0 || checkCol >= Helpers.CHESS_BOARD_WIDTH ||
                        board[checkRow, checkCol] != player)
                    {
                        win = false;
                        break;
                    } 
                }
                if (win) return true;
            }
            
            // Kiểm tra đường chéo phụ
            for(int i = -4; i < 1; i++)
            {
                bool win = true;
                for (int j = 0; j < 5; j++)
                {
                    int checkRow = row + i + j;
                    int checkCol = col - i - j;
                    if (checkRow < 0 || checkRow >= Helpers.CHESS_BOARD_HEIGHT ||
                        checkCol < 0 || checkCol >= Helpers.CHESS_BOARD_WIDTH ||
                        board[checkRow, checkCol] != player)
                    {
                        win = false;
                        break;
                    }
                }
                if (win) return true;
            }
            return false;
        }
            
        private void btn_newGame_Click(object sender, EventArgs e)
        {
            timer_Lose.Stop();
            this.Hide();
            FrmAI frmAI = new FrmAI(levelAI);
            frmAI.ShowDialog();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            timer_Lose.Stop();
            this.Close();
        }
        private void btn_Undo_Click(object sender, EventArgs e)
        {
            if (undoStack.Count >= 2) 
            {
                for (int i = 0; i < 2; i++) // Quay lại 2 nước đi
                {
                    Move lastMove = undoStack.Pop();
                    redoStack.Push(new Move(lastMove.Row, lastMove.Col, board[lastMove.Row, lastMove.Col])); // Đẩy vào redoStack
                    board[lastMove.Row, lastMove.Col] = null; // Xóa nước đi khỏi bàn cờ
                    UpdateButtonUI(lastMove.Row, lastMove.Col, null); 
                }
                isYourTurn = true;
                isComputerTurn = false;
            }
            else
            {
                MessageBox.Show("Không thể thực hiện Undo!");
            }
        }
        private void btn_Redo_Click(object sender, EventArgs e)
        {
            if (redoStack.Count >= 2) 
            {
                for (int i = 0; i < 2; i++)
                {
                    Move nextMove = redoStack.Pop();
                    undoStack.Push(new Move(nextMove.Row, nextMove.Col, board[nextMove.Row, nextMove.Col]));
                    board[nextMove.Row, nextMove.Col] = nextMove.Player; 
                    UpdateButtonUI(nextMove.Row, nextMove.Col, nextMove.Player);
                }
                isYourTurn = true;
                isComputerTurn = false;
            }
            else
            {
                MessageBox.Show("Không còn nước đi để Redo!");
            }
        }
        private void UpdateButtonUI(int row, int col, string player)
        {
            foreach (Control c in pn_ChessBoard.Controls)
            {
                if (c is Guna2ButtonWithPosition btn && btn.Row == row && btn.Col == col)
                {
                    if (player == null)
                    {
                        btn.BackgroundImage = null; 
                    }
                    else
                    {
                        string imagePath = Path.Combine(Application.StartupPath, $"Assess\\Images\\{player}.png");
                        btn.BackgroundImage = Image.FromFile(imagePath);
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    break;
                }
            }
        }

    }
}