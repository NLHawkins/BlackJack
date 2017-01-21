using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Gambler player = new Gambler(null, 0, 0);
            Gambler dealer = new Gambler(null, 0, 0);
            bool stand = false;
            while(stand == false)
            {
                player.AddCardToHand();



            }


        }
    }
}
