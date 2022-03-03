using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tap.Hangman.App
{
    internal class RomanianHangmanGame :HangmanGame
    {
        private protected override List<String> Listofwords {
            get {
                List<String> anotherlist = new List<String>();
                anotherlist.Add("primavara");
                anotherlist.Add("iarna");
                return anotherlist;
            }
        }

    }
}
