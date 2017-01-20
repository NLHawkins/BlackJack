using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Gambler
    {
        public int holdingValue;
        public int numbOfCards;

        public Gambler()
        {

        }

        public Gambler(int _numberOfCards, int _holdingValue)
        {
            numbOfCards = _numberOfCards;
            holdingValue = _holdingValue;
        }

        public int getNumbofCards()
        {
            return numbOfCards;
        }

        public int getHoldingValue()
        {
            return holdingValue;
        }
    }

}
