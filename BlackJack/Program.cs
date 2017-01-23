using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Program
    {


        public static Hand player;
        public static Hand dealer;
        public static List<Card> gameDeck;
        public static bool stand = false;
        public static bool keepPlaying = true;
        public static string keepPlayingYN;

        public static int purse = 100;
        public static int handsWon = 0;
        public static string handResult;
        public static Card card;
        public static int holdingValue;



        public static void Main(string[] args)
        {
            Console.WriteLine("Let's Play BlackJack");
            Console.WriteLine();
           
            while (purse > 0 && GamePlay.keepPlaying == true)
            {
                GamePlay.getDeck();

                GamePlay.dealCardtoPlayerHand();
                GamePlay.dealCardtoPlayerHand();
                GamePlay.showPlayerHand();
                GamePlay.player.getHoldingValue();

                GamePlay.dealCardtoDealerHand();
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
                
                
                    GamePlay.dealerPlaysHand();
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
