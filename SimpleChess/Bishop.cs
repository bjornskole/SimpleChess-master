using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChess
{
    internal class Bishop : Piece
    {
        public Bishop() : base("LPR")
        {   
        }
        

        public override bool Move(string fromPosition, string toPosition)
        {
            
                var diffCol = fromPosition[0] - toPosition[0];
                var diffRow = fromPosition[1] - toPosition[1];
                return Math.Abs(diffRow) == Math.Abs(diffCol);
            
            
        }
    }
}
