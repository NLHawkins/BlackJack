using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{


    public enum Suits
    {
        Club, Spade, Diamond, Heart
    }

    public enum Faces
    {
        Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
        Jack, Queen, King, Ace
    }

    public class Card
    {
        public Suits suit;
        public Faces face;
        //public int value;
        



        public Card()
        {

        }
        //took out value!!!!!!**************************
        public Card(Suits _suit, Faces _face)
        {
            suit = _suit;
            face = _face;
            //value = _value;

        }

        public Suits getSuit()
        {
            return suit;
        }

        public Faces getFace()
        {
            return face;
        }
        /*
        public int getValue()
        {
            return value;
        }
        */
    }




}
