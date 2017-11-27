using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIT323_Project02
{
    class TestCrozzleFirstLine
    {

        // first Line
        public string Level;
        public int Amount;
        public int Row, Column;
        public int H_Number, V_Number;

        public TestCrozzleFirstLine(string Level, int Amount, int Row, int Column, int H_Number, int V_Number)
        {

            this.Level = Level;
            this.Amount = Amount;
            this.Row = Row;
            this.Column = Column;
            this.H_Number = H_Number;
            this.V_Number = V_Number;
        }

        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3},{4},{5}", Level, Amount, Row, Column, H_Number, V_Number);
        }
    }
}