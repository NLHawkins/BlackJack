using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack;

namespace BlackJack
{
    public class CardFactory
    {
        
        public static List<Card> CreateDeck()

        {
            List<Faces> faceList = new List<Faces>()
                    {
                        Faces.Two, Faces.Three, Faces.Four,
                        Faces.Five,Faces.Six, Faces.Seven,
                        Faces.Eight, Faces.Nine, Faces.Ten,
                        Faces.Jack, Faces.Queen, Faces.King, Faces.Ace
                    };

            List<Suits> suitList = new List<Suits>()
                    {
                        Suits.Club, Suits.Diamond, Suits.Heart, Suits.Spade
                    };


           List<Card> CardDeck = new List<Card>();

            for (int numbOfSuits = 0; numbOfSuits < 4; numbOfSuits++)
            {
                for (int numbOfFaces = 0; numbOfFaces < 13; numbOfFaces++)
                {
                    CardDeck.Add(new Card(suitList[numbOfSuits], faceList[numbOfFaces],(int)faceList[numbOfFaces]));
                }
            }

            return CardDeck;
        }

        public static List<Card> getSuitTestList()
        {
            List<Faces> faceList = new List<Faces>()
                    {
                        Faces.Two, Faces.Three, Faces.Four,
                        Faces.Five,Faces.Six, Faces.Seven,
                        Faces.Eight, Faces.Nine, Faces.Ten,
                        Faces.Jack, Faces.Queen, Faces.King, Faces.Ace
                    };

            List<Suits> suitList = new List<Suits>()
                    {
                        Suits.Club, Suits.Diamond, Suits.Heart, Suits.Spade
                    };


            List<Card> SuitTestList = new List<Card>();
            List<Card> CardDeck = new List<Card>();

            for (int numbOfSuits = 0; numbOfSuits < 4; numbOfSuits++)
            {
                for (int numbOfFaces = 0; numbOfFaces < 13; numbOfFaces++)
                {
                    CardDeck.Add(new Card(suitList[numbOfSuits], faceList[numbOfFaces], (int)faceList[numbOfFaces]));
                }
            }

            foreach (var card in CardDeck)
            {
                card.getSuit();
                if (card.getSuit() == Suits.Club)
                    SuitTestList.Add(card);
            }

            return SuitTestList;



        }




    }
}
