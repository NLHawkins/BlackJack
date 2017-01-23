using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BlackJack
{
    public class GamePlay
    {



        private static Hand player = new Hand(0,0);
        public static Hand dealer = new Hand(0,0);
        public static List<Card> gameDeck;
        public static bool stand = false;
        public static string choice;
        public static int purse = 100;
        public static int handsWon = 0;
        public static string handResult;
        public static bool keepPlaying;
        public static string keepPlayingYN;
        public static Card card;

            
        public GamePlay()
        {

        }

        public static void keepGoing()
        {
            if(keepPlayingYN == "n")
            {
                keepPlaying = false;
            }
            else
            {
                keepPlaying = true;
            }
        }

        public static void getHandResult()
        {
            if (player.getHoldingValue() > 21)
            {
                handResult = "Lose";
            }
            else if (dealer.getHoldingValue() > 21)
            {
                handResult = "Win";
            }
            else if (player.getHoldingValue() < dealer.getHoldingValue())
            {
                handResult = "Lose";
            }
            else if (player.getHoldingValue() > dealer.getHoldingValue())
            {
                handResult = "Win";
            }
            else if (player.getHoldingValue() == dealer.getHoldingValue())
            {
                handResult = "Push";
            }
        }

        public static void purseChange()
        {
            if(handResult == "Win")
            {
                purse = purse + 10;
            }

            else if(handResult == "Lose")
            {
                purse = purse - 10;
            }

            else if(handResult == "Push")
            {
                purse = purse;
            }
            Console.WriteLine($"Purse: ${purse}");
        }

        public static List<Card> getDeck()
        {
            gameDeck = CardFactory.CreateDeck();
            return gameDeck;
        }

        public static void dealCardtoPlayerHand()
        {
            Random rng = new Random();
            Card card = gameDeck[rng.Next(gameDeck.Count())];
            player.hand.Add(card);
            player.handNameList.Add(card.getName());           
            gameDeck.Remove(card);
            
        }

        public static void dealCardtoDealerHand()
        {
            Random rng = new Random();
            Card card = gameDeck[rng.Next(gameDeck.Count())];
            dealer.hand.Add(card);
            dealer.handNameList.Add(card.getName());
            gameDeck.Remove(card);
           
        }

        public static void dealerPlaysHand()
        {
            while(dealer.holdingValue <= 16)
            {
                Console.WriteLine("Dealer Hit's");
                dealCardtoDealerHand();
            }
        }

        public static void showPlayerHand()
        {
            Console.WriteLine("Your Hand:");
            Console.WriteLine();
            foreach (var name in player.handNameList)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
        }

        public static void showDealerHand()
        {
            Console.WriteLine("Dealer's Hand:");
            Console.WriteLine("X");
            for (int i = 1; i < dealer.handNameList.Count(); i++)
            {
                Console.Write(dealer.handNameList[i]);
            }
            Console.WriteLine();
        }

        public static void makeChoice()
        {

            
            if (choice.ToLower() == "hit")
            {
                dealCardtoPlayerHand();
            }

            else if(choice.ToLower() == "stand")
            {
                stand = true; 
            }

            else
            {
                Console.WriteLine("That is not a choice. Please choose to hit or stand");
                makeChoice();
            }
                   
        }



        
    }
}
