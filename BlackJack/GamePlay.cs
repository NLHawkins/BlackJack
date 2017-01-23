using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BlackJack
{
    public class GamePlay
    {



        public static Hand player = new Hand(0,0);
        public static Hand dealer = new Hand(0,0);
        public static List<Card> gameDeck;
        public static bool stand = false;
        public static string choice;
        public static int purse = 100;
        public static int handsWon = 0;
        public static string handResult;
        public static bool keepPlaying = true;
        public static string keepPlayingYN;
        public static Card card;
        public static bool notBusted = true;


        public GamePlay()
        {

        }

        public static int playerValue = player.getHoldingValue();
        public static int dealerValue = dealer.getHoldingValue();
        public static void keepGoing()
        {
            if(keepPlayingYN == "n")
            {
                keepPlaying = false;
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Purse: ${purse}");
                Console.WriteLine("Next Hand");
                Console.WriteLine("*****************************************");
                gameDeck = CardFactory.CreateDeck();
                stand = false;
                player.holdingValue = 0;
                dealer.holdingValue = 0;
                player = new Hand(0, 0);
                dealer = new Hand(0, 0);
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
                Console.WriteLine("Its a Push");
                Console.WriteLine();
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

        public static Card dealCardtoDealerHand()
        {
            Random rng = new Random();
            Card card = gameDeck[rng.Next(gameDeck.Count())];
            dealer.hand.Add(card);
            dealer.handNameList.Add(card.getName());
            gameDeck.Remove(card);
            return card;
           
        }

        public static void bustCheck()
        {
            if(player.getHoldingValue() > 21)
            {
                Console.WriteLine("You BUSTED");
                notBusted = false;
                keepPlaying = false;
                
            }
        }

        public static void dealerPlaysHand()
        {
            reavealDealerHand();
            
            while (dealer.getHoldingValue() <= 16)
            {
                Console.WriteLine("Dealer Hit's");
                Console.WriteLine();
                dealCardtoDealerHand();
                reavealDealerHand();
                Console.WriteLine();

            }
            if (dealer.getHoldingValue() > 16 && dealer.getHoldingValue() < 22)
            {

                Console.WriteLine($"Dealer stands at {dealer.getHoldingValue()}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Dealer Busts");
                Console.WriteLine();
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
            Console.WriteLine();
            Console.WriteLine("X");
            for (int i = 1; i < dealer.handNameList.Count(); i++)
            {
                Console.Write(dealer.handNameList[i]);
            }
            Console.WriteLine();
        }

        public static void reavealDealerHand()
        {
            Console.WriteLine("Dealer's Hand:");           
            for (int i = 0; i < dealer.handNameList.Count(); i++)
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
