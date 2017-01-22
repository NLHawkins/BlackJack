using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Purse
    {
        public static int dollars = 100;
        public Purse()
        {

        }

        public Purse(int _dollars)
        {
            dollars = _dollars;
        }

        public static void showPurse()
        {
            Console.WriteLine($"Purse: ${dollars}");
        }
    }
}
