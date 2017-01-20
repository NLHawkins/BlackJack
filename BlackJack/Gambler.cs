using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack;

namespace BlackJack
{
    public class Gambler
    {
        public int holdingValue;
        public int numbOfCards;
        public List<Card> handList = new List<Card>();
        
        public Gambler()
        {
        }
        //  removed from below for testing .  List<Card> _handList,
        public Gambler( int _numberOfCards, int _holdingValue)
        {

            //handList = _handList;
            numbOfCards = _numberOfCards;
            holdingValue = _holdingValue;
        }

        public List<Card> getHandList()
        {
            return handList;
        }

        public int getNumbofCards()
        {
            
            return numbOfCards;
        }

        public int getHoldingValue()
        {
            return holdingValue;
        }

        public Card hit()
        {
            return GamePlay.DealCard();
                
        }
    }

}
