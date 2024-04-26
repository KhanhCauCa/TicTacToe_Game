using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameCaroAI.Classes;
using System.Windows.Forms;

namespace GameCaroAI.Option
{
    public class HardOption
    {
        private string[,] board;
        private int maxDepth;
        private const string AI_PIECE = "O";
        private const string PLAYER_PIECE = "X";

        public HardOption(string[,] board, int maxDepth)
        {
            this.board = board;
            this.maxDepth = maxDepth;
        }

        public int[] findBestMove()
        {
            int bestScore = int.MinValue;
            int[] bestMove = new int[2];
            int alpha = int.MinValue;
            int beta = int.MaxValue;

            for (int i = 0; i < Helpers.CHESS_BOARD_HEIGHT; i++)
            {
                for (int j = 0; j < Helpers.CHESS_BOARD_WIDTH; j++)
                {
                    if (board[i, j] == null)
                    {
                        board[i, j] = AI_PIECE;
                        int score = MinimaxWithAlphaBeta(board, 0, false, alpha, beta);
                        board[i, j] = null;
                        if (score > bestScore)
                        {
                            bestScore = score;
                            bestMove[0] = i;
                            bestMove[1] = j;
                        }
                    }
                }
            }

            return bestMove;
        }
        public int MinimaxWithAlphaBeta(string[,] board, int depth, bool isMaximizing, int alpha, int beta)
        {
            if (depth == maxDepth || IsGameOver(board))
            {
                return Evaluate(board, AI_PIECE);
            }
            if (isMaximizing)
            {
                int bestScore = int.MinValue;
                for (int i = 0; i < Helpers.CHESS_BOARD_HEIGHT; i++)
                {
                    for (int j = 0; j < Helpers.CHESS_BOARD_WIDTH; j++)
                    {
                        if (board[i, j] == null)
                        {
                            board[i, j] = AI_PIECE;
                            int score = MinimaxWithAlphaBeta(board, depth + 1, false, alpha, beta);
                            board[i, j] = null;
                            bestScore = Math.Max(bestScore, score);
                            alpha = Math.Max(alpha, bestScore);
                            if (beta <= alpha)
                            {
                                break; // Cắt tỉa Beta
                            }
                        }
                    }
                    if (beta <= alpha)
                    {
                        break; // Cắt tỉa Beta
                    }
                }
                return bestScore;
            }
            else
            {
                int bestScore = int.MaxValue;
                for (int i = 0; i < Helpers.CHESS_BOARD_HEIGHT; i++)
                {
                    for (int j = 0; j < Helpers.CHESS_BOARD_WIDTH; j++)
                    {
                        if (board[i, j] == null)
                        {
                            board[i, j] = PLAYER_PIECE;
                            int score = MinimaxWithAlphaBeta(board, depth + 1, true, alpha, beta);
                            board[i, j] = null;
                            bestScore = Math.Min(bestScore, score);
                            beta = Math.Min(beta, bestScore);
                            if (beta <= alpha)
                            {
                                break; // Cắt tỉa Alpha
                            }
                        }
                    }
                    if (beta <= alpha)
                    {
                        break; // Cắt tỉa Alpha
                    }
                }
                return bestScore;
            }
        }
        public int Evaluate(string[,] board, string player)
        {
            int score = 0;

            // Đánh giá các hàng ngang
            for (int i = 0; i < Helpers.CHESS_BOARD_HEIGHT; i++)
            {
                for (int j = 0; j <= Helpers.CHESS_BOARD_WIDTH - 5; j++)
                {
                    score += EvaluateLine(board, player, i, j, 0, 1); // Hàng ngang
                }
            }

            // Đánh giá các hàng dọc
            for (int i = 0; i <= Helpers.CHESS_BOARD_HEIGHT - 5; i++)
            {
                for (int j = 0; j < Helpers.CHESS_BOARD_WIDTH; j++)
                {
                    score += EvaluateLine(board, player, i, j, 1, 0); // Hàng dọc
                }
            }

            // Đánh giá các đường chéo chính
            for (int i = 0; i <= Helpers.CHESS_BOARD_HEIGHT - 5; i++)
            {
                for (int j = 0; j <= Helpers.CHESS_BOARD_WIDTH - 5; j++)
                {
                    score += EvaluateLine(board, player, i, j, 1, 1); // Đường chéo chính
                }
            }

            // Đánh giá các đường chéo phụ
            for (int i = 4; i < Helpers.CHESS_BOARD_HEIGHT; i++)
            {
                for (int j = 0; j <= Helpers.CHESS_BOARD_WIDTH - 5; j++)
                {
                    score += EvaluateLine(board, player, i, j, -1, 1); // Đường chéo phụ
                }
            }

            return score;
        }

        public int EvaluateLine(string[,] board, string player, int row, int col, int dRow, int dCol)
        {
            int score = 0;
            int playerCount = 0; // Số lượng ô đã được chiếm bởi người chơi hiện tại
            int opponentCount = 0; // Số lượng ô đã được chiếm bởi đối thủ
            string opponent = player == AI_PIECE ? PLAYER_PIECE : AI_PIECE;

            for (int i = 0; i < 5; i++)
            {
                int r = row + i * dRow;
                int c = col + i * dCol;
                if (board[r, c] == player)
                    playerCount++;
                else if (board[r, c] == opponent)
                    opponentCount++;
            }

            // Đánh giá trường hợp chiến thắng
            if (playerCount == 5)
                score += 1000000;
            else if (playerCount == 4 && opponentCount == 0)
            {
                if (opponentCount == 1 && playerCount == 4)
                    score += 25000;
                else
                    score += 40000; 
            }
            else if (playerCount == 3 && opponentCount == 0)
            {

                if (opponentCount == 1 && playerCount == 3)
                    score += 1000;
                else
                    score += 2000;
            }
            else if (playerCount == 2 && opponentCount == 0)
            {
                if (opponentCount == 1 && playerCount == 2)
                    score += 100;
                else
                    score += 100;
            }
            else if (playerCount == 1 && opponentCount == 0)
            {
                score += 10;
            }

            // Ngăn chặn đối thủ
            if (opponentCount == 4 && playerCount == 0)
            {
                if (opponentCount == 4 && playerCount == 1)
                    score -= 100000;
                else
                    score -= 100000;
            }
            else if (opponentCount == 3 && playerCount == 0)
            {
                if (opponentCount == 3 && playerCount == 1)
                    score -= 5000;
                else
                    score -= 10000;
            }
            else if (opponentCount == 2 && playerCount == 0)
            {
                if (opponentCount == 2 && playerCount == 1)
                    score -= 100;
                else
                    score -= 200;

            }
            else if (opponentCount == 1 && playerCount == 0)
                score -= 10;

            return score;
        }
        public bool IsGameOver(string[,] board)
        {
            // Cờ hòa
            for (int i = 0; i < Helpers.CHESS_BOARD_HEIGHT; i++)
            {
                for (int j = 0; j < Helpers.CHESS_BOARD_WIDTH; j++)
                {
                    if (board[i, j] == null)
                    {
                        return true;
                    }
                }
            }
            MessageBox.Show("Cờ hòa !");
            return false;
        }
    }
}
