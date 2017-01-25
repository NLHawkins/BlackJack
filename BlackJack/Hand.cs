using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack;

namespace BlackJack
{
    public class Hand
    {
        public int holdingValue;
        public int numbOfCards;
        public List<string> handNameList = new List<string>();
        public List<Card> hand = new List<Card>();

        public Hand()
        {
        }       

        public Hand(int _numbOfCards, int _holdingValue)
        {
            numbOfCards = _numbOfCards;
            holdingValue = _holdingValue;
        }

        public List<string> getHandNameList()
        {
            return handNameList;
        }

        public int getNumbofCards()
        {
            numbOfCards = hand.Count();
            return numbOfCards;
        }

        public int getHoldingValue()
        {
            holdingValue = 0;
            foreach (var card in hand)
            {
                holdingValue += card.getValue();
                if (holdingValue > 21 && card.getFace() == Faces.Ace)
                {
                    holdingValue = holdingValue - 10;
                }
            }
            return holdingValue;
        }
    }
}
