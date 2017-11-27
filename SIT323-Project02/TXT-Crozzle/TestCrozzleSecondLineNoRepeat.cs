using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIT323_Project02
{
    class TestCrozzleSecondLineNoRepeat
    {
        // Second Line
        public string wordlist;
        public char[] letter;


        public TestCrozzleSecondLineNoRepeat(string wordlist, string letter)
        {

            this.wordlist = wordlist;
            this.letter = letter.ToCharArray();

        }
    }
}