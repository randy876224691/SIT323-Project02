﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIT323_Project02
{
    class VerticalWordPosition
    {
        public int X, Y;
        public char letter;
        public string wholeword;

        public VerticalWordPosition(int X, int Y, char letter, string wholeword)
        {
            this.X = X;
            this.Y = Y;
            this.letter = letter;
            this.wholeword = wholeword;
        }
    }
}
