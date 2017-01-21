using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BlackJack
{
    public class GamePlay
    {


        

        public Card dealCard()
        {
            Card card = new Card();
            List<Card> gameDeck = new List<Card>();
            Gambler player = new Gambler();
            Random rng = new Random();

            while (!gameDeck.Contains(card))
            {
                card = gameDeck[rng.Next(52)];
            }
            gameDeck.Remove(card);
            return card;
        }



        public void addtoXHand(Gambler player)
        {
            var card = dealCard();
            player.hand.Add(card);
            player.handNameList.Add(card.getName());

        }


        /*
        public static void addToHandList()
        {
            
        }
        */
    }
}
