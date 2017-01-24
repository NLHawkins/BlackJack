using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Program
    {

        private static int purse = 100;
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Let's Play BlackJack");
            Console.WriteLine();

            while (purse > 0 && GamePlay.keepPlaying == true)
            {
                GamePlay.getDeck();

                GamePlay.dealCardtoPlayerHand();
                Console.WriteLine("Press <enter> to deal cards");
                Console.WriteLine();
                Console.ReadLine();
                GamePlay.dealCardtoPlayerHand();
                GamePlay.showPlayerHand();
                GamePlay.player.getHoldingValue();

                GamePlay.dealCardtoDealerHand();
                Console.WriteLine("Press <enter> to deal the dealers card");
                Console.WriteLine();
                Console.ReadLine();
                GamePlay.dealCardtoDealerHand();
                GamePlay.showDealerHand();
                GamePlay.dealer.getHoldingValue();

                while (GamePlay.player.getHoldingValue() <= 21 && GamePlay.stand == false)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Your Hand has a value of {GamePlay.player.getHoldingValue()}");
                    Console.WriteLine("Please choose [hit] or [stand]");
                    Console.WriteLine();
                    GamePlay.choice = Console.ReadLine();
                    GamePlay.makeChoice();
                    GamePlay.showPlayerHand();
                    GamePlay.player.getHoldingValue();
                    GamePlay.bustCheck();
                }

                if (GamePlay.busted == false)
                {
                    GamePlay.dealerPlaysHand();
                }

                GamePlay.getHandResult();
                GamePlay.purseChange();

                Console.WriteLine("Would you like to continue playing? y/n");
                GamePlay.keepPlayingYN = Console.ReadLine();
                GamePlay.keepGoing();
            }

            if (purse < 1)
            {
                Console.WriteLine("You are out of money, sell your shoes and play again");
            }

            else
            {
                Console.WriteLine($"Thanks for playing! You're taking home ${GamePlay.purse}");
            }
        }
    }
}
