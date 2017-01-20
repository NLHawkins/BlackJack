using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BlackJack
{
    public class GamePlay
    {


        public static Card DealCard()
        {
            List<Card> gameDeck = new List<Card>(CardFactory.CreateDeck());
            Random rng = new Random();
            Card dealtCard = new Card();
            while (!gameDeck.Contains(dealtCard))
            {
                dealtCard = gameDeck[rng.Next(52)];
            }
            gameDeck.Remove(dealtCard);
            return dealtCard;

        }

        //public static Card AddtoHandList()
        
    }
}
