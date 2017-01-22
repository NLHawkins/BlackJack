using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {


        public static Hand player;
        public static Hand dealer;
        public static List<Card> gameDeck;
        public static bool stand = false;
        public static bool keepPlaying = true;
        public static string keepPlayingYN;
        public static string choice;
        public static int purse = 100;
        public static int handsWon = 0;
        public static string handResult;
        public static Card card;


        public static void Main(string[] args)
        {
            Console.WriteLine("Let's Play BlackJack");
            while (purse > 0 && keepPlaying == true)
            {
                GamePlay.getDeck();
                GamePlay.dealCardtoPlayerHand();
                GamePlay.dealCardtoPlayerHand();
                GamePlay.showPlayerHand();

                GamePlay.dealCardtoDealerHand();
                GamePlay.dealCardtoDealerHand();
                GamePlay.showDealerHand();

                while (player.getHoldingValue() <= 21 && stand == false)
                {
                    GamePlay.showPlayerHand();
                    Console.WriteLine($"Your Hand has a value of {player.getHoldingValue()}");
                    Console.WriteLine("Please choose [hit] or [stand]");
                    choice = Console.ReadLine();
                    GamePlay.makeChoice();
                }

                GamePlay.getHandResult();
                GamePlay.purseChange();
                Console.WriteLine("Would you like to continue playing? y/n");
                keepPlayingYN = Console.ReadLine();
                GamePlay.keepGoing();
            }
            if (purse < 1)
            {
                Console.WriteLine("You are out of money, sell your shoes and play again");
            }

            else
            {
                Console.WriteLine($"Thanks for playing! You're taking home {player.getHoldingValue()}");
            }

           
            

















            /* while(stand == false)
             {
                 //player.AddCardToHand();
                 //player.AddCardToHand();
                // Console.WriteLine(player.getHandList());



             }
             */

        }
    }
}
