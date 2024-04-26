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
using Guna.UI2.WinForms;

namespace GameCaroAI.GUI
{
    public partial class Frm_TwoPlayers : Form
    {
        public bool isXTurn = true;
        public bool isOTurn = true;
        public int xCount = 0;
        public int oCount = 0;
        public string[,] board = new string[Helpers.CHESS_BOARD_WIDTH, Helpers.CHESS_BOARD_HEIGHT];
        private Stack<Point> moveHistory = new Stack<Point>(); 
        private Stack<Point> undoneMoves = new Stack<Point>();
        public Frm_TwoPlayers()
        {
            InitializeComponent();
            DrawChessBoard();
        }       
        private void Btn_Click(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            btn.BackColor = Color.Transparent;
            if (btn != null && btn.BackgroundImage == null)
                               
            {
                int row = btn.Location.Y / Helpers.CHESS_HEIGHT;
                int col = btn.Location.X / Helpers.CHESS_WIDTH;
                if (isXTurn)
                {
                    string imagePath = Path.Combine(Application.StartupPath, "Assess/Images/X.png");
                    btn.BackgroundImage = Image.FromFile(imagePath);

                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    board[col, row] = "X";
                    xCount++;
                    lbl_X.Text = "X: " + xCount.ToString();
                    moveHistory.Push(new Point(col, row));
                    undoneMoves.Clear();
                    if (CheckWinner(col, row))
                    {
                        MessageBox.Show("Player X wins!");
                        return;
                    }
                    isXTurn = false;
                    isOTurn = true;
                }
                else if (isOTurn)
                {
                    string imagePath = Path.Combine(Application.StartupPath, "Assess/Images/O.png");
                    btn.BackgroundImage = Image.FromFile(imagePath);

                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    board[col, row] = "O";
                    oCount++;
                    lbl_O.Text = "O: " + oCount.ToString();

                    moveHistory.Push(new Point(col, row));
                    undoneMoves.Clear();
                    if (CheckWinner(col, row))
                    {
                        MessageBox.Show("Player O wins!");
                        return;
                    }
                    isXTurn = true;
                    isOTurn = false;
                }
            }
        }

        private bool CheckWinner(int col, int row)
        {
            string player = isXTurn ? "X" : "O";

            // Kiểm tra hàng ngang
            for (int i = 0; i < Helpers.CHESS_BOARD_WIDTH - 4; i++)
            {
                bool win = true;
                for (int j = 0; j < 5; j++)
                {
                    if (board[i + j, row] != player)
                    {
                        win = false;
                        break;
                    }
                }
                if (win) return true;
            }

            // Kiểm tra hàng dọc
            for (int i = 0; i < Helpers.CHESS_BOARD_HEIGHT - 4; i++)
            {
                bool win = true;
                for (int j = 0; j < 5; j++)
                {
                    if (board[col, i + j] != player)
                    {
                        win = false;
                        break;
                    }
                }
                if (win) return true;
            }

            // Kiểm tra đường chéo chính
            for (int i = -4; i < 1; i++)
            {
                bool win = true;
                for (int j = 0; j < 5; j++)
                {
                    if (col + i + j < 0 || col + i + j >= Helpers.CHESS_BOARD_WIDTH || row + i + j < 0 || row + i + j >= Helpers.CHESS_BOARD_HEIGHT)
                    {
                        win = false;
                        break;
                    }
                    if (board[col + i + j, row + i + j] != player)
                    {
                        win = false;
                        break;
                    }
                }
                if (win) return true;
            }

            // Kiểm tra đường chéo phụ
            for (int i = -4; i < 1; i++)
            {
                bool win = true;
                for (int j = 0; j < 5; j++)
                {
                    if (col + i + j < 0 || col + i + j >= Helpers.CHESS_BOARD_WIDTH || row - i - j < 0 || row - i - j >= Helpers.CHESS_BOARD_HEIGHT)
                    {
                        win = false;
                        break;
                    }
                    if (board[col + i + j, row - i - j] != player)
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
            this.Close();
            Frm_TwoPlayers frm_two = new Frm_TwoPlayers();
            frm_two.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Undo_Click(object sender, EventArgs e)
        {
            if (moveHistory.Count > 0)
            {
                Point lastMove = moveHistory.Pop();
                undoneMoves.Push(lastMove);

                int col = lastMove.X;
                int row = lastMove.Y;
                Guna2Button btn = pn_ChessBoard.Controls.Cast<Control>()
                    .FirstOrDefault(control => control.Location.X / Helpers.CHESS_WIDTH == col
                                    && control.Location.Y / Helpers.CHESS_HEIGHT == row)
                    as Guna2Button;
                btn.BackgroundImage = null;

                board[col, row] = null;
                if (isXTurn)
                {
                    xCount--;
                    lbl_X.Text = "X: " + xCount.ToString();
                }
                else if (isOTurn)
                {
                    oCount--;
                    lbl_O.Text = "O: " + oCount.ToString();
                }
                isXTurn = !isXTurn;
                isOTurn = !isOTurn;
            }
        }


        private void btn_Redo_Click(object sender, EventArgs e)
        {
            if (undoneMoves.Count > 0)
            {
                Point redoMove = undoneMoves.Pop();
                moveHistory.Push(redoMove);

                int col = redoMove.X;
                int row = redoMove.Y;

                Guna2Button btn = pn_ChessBoard.Controls
                    .Cast<Control>()
                    .FirstOrDefault(control => control.Location.X / Helpers.CHESS_WIDTH == col && 
                    control.Location.Y / Helpers.CHESS_HEIGHT == row) 
                    as Guna2Button;

                if (isXTurn)
                {
                    string imagePath = Path.Combine(Application.StartupPath, "Assess/Images/X.png");
                    btn.BackgroundImage = Image.FromFile(imagePath);

                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    board[col, row] = "X";
                    xCount++;
                    lbl_X.Text = "X: " + xCount.ToString();
                }
                else if (isOTurn)
                {
                    string imagePath = Path.Combine(Application.StartupPath, "Assess/Images/O.png");
                    btn.BackgroundImage = Image.FromFile(imagePath);

                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    board[col, row] = "O";
                    oCount++;
                    lbl_O.Text = "O: " + oCount.ToString();
                }

                if (CheckWinner(col, row))
                {
                    MessageBox.Show((isXTurn ? "X" : "O") + " wins!");
                }

                isXTurn = !isXTurn;
                isOTurn = !isOTurn;
            }
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_TwoPlayers frm_two = new Frm_TwoPlayers();
            frm_two.ShowDialog();
        }
	}
}
