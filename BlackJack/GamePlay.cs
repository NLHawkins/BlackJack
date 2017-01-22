using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BlackJack
{
    public class GamePlay
    {



        public static Hand player;
        public static Hand dealer;
        public static List<Card> gameDeck;


        public GamePlay()
        {

        }

        public static List<Card> getDeck()
        {
            gameDeck = CardFactory.CreateDeck();
            return gameDeck;
        }

        public static Card dealCardtoPlayerHand()
        {
            Random rng = new Random();   
            Card card = gameDeck[rng.Next(52)];
            player.hand.Add(card);
            player.handNameList.Add(card.getName());           
            gameDeck.Remove(card);
            return card;
        }

        public static void dealCardtoDealerHand()
        {
            Random rng = new Random();
            Card card = gameDeck[rng.Next(52)];
            dealer.hand.Add(card);
            dealer.handNameList.Add(card.getName());
            gameDeck.Remove(card);
           
        }



        public static void showPlayerHand()
        {
            foreach (var name in player.handNameList)
            {
                Console.WriteLine(name);
            }
        }

        public static void showDealerHand()
        {
            for (int i = 1; i < dealer.handNameList.Count(); i++)
            {
                Console.WriteLine(dealer.handNameList[i]);
            }
        }

        public static

        
    }
}
