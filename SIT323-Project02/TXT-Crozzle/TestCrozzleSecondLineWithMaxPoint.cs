using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIT323_Project02
{
    class TestCrozzleSecondLineWithMaxPoint
    {
        // Second Line
        public string wordlist;
        public char[] letter;
        public int maxvalue;


        public TestCrozzleSecondLineWithMaxPoint(string wordlist, string letter, int maxvalue)
        {

            this.wordlist = wordlist;
            this.letter = letter.ToCharArray();
            this.maxvalue = maxvalue;

        }
    }
}
