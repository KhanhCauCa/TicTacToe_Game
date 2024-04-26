using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameCaroAI.Classes;

namespace GameCaroAI.Option
{
    public class EasyOption
    {
        private string[,] board;
        private Random random;
        public EasyOption(string[,] board)
        {
            this.board = board;
            this.random = new Random();
        }
        public int[] findMove()
        {
            List<int[]> lstMove = new List<int[]>();
            Dictionary<int[], int> moveScore = new Dictionary<int[], int>();
            for (int i = 0; i < Helpers.CHESS_BOARD_HEIGHT; i++)
            {
                for (int j = 0;j < Helpers.CHESS_BOARD_WIDTH; j++)
                {
                    if (board[i,j]  == null)
                    {
                        int[] move = new int[] { i, j };
                        int score = CalculMoveScore(i, j);
                        lstMove.Add(move);
                        moveScore.Add(move, score);
                    }
                }
            }
            if (lstMove.Count == 0)
            {
                return null;
            }
            // Sắp xếp nước đi theo điểm số
            lstMove.Sort((a,b) => moveScore[b].CompareTo(moveScore[a]));
            int topScore = moveScore[lstMove[0]];
            var bestMove = lstMove.Where(m => moveScore[m] == topScore).ToList();
            int moveIndex = random.Next(bestMove.Count);
            return bestMove[moveIndex];
        }

        public int CalculMoveScore(int row, int col)
        {
            int cenTer = Helpers.CHESS_BOARD_HEIGHT / 2;
            int distanceToCenTer = Math.Max(Math.Abs(row - cenTer), Math.Abs(col - cenTer));
            int score = (cenTer - distanceToCenTer);
            return score;
        }
    }
}
