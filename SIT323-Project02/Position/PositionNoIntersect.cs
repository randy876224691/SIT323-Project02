using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIT323_Project02
{
    class PositionNoIntersect
    {
        public int X, Y;
        public char letter;
        public string word;

        public PositionNoIntersect(int X, int Y, char letter, string word)
        {
            this.X = X;
            this.Y = Y;
            this.letter = letter;
            this.word = word;
        }
    }
}
