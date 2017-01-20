using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BlackJack
{
    class GamePlay
    {
        public static List<Card> DealCard(int count)
        {

            var gameDeck = new List<Card>(CardFactory.CreateDeck());
            var gameCard = new Card();
            var rng = new Random();

            CardFactory.CreateDeck();
            for (int i = 0; i < count; i++)
            {
                gameCard = gameDeck[rng.Next(52)];
            }

            return gameCard;
        }
//public Card(Suits _suit, Faces _face)

    }
}
