using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCaroAI.Classes
{
    public class Move
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public string Player { get; set; }
        public Move(int row, int col, string player)
        {
            Row = row;
            Col = col;
            Player = player;
        }
    }

}
