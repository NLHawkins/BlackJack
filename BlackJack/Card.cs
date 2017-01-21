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
        Two = 2, Three = 3, Four = 4, Five = 5, Six = 6,
        Seven = 7, Eight = 8, Nine = 9, Ten = 10,
        Jack = 10, Queen = 10, King = 10, Ace = 11
    }

    public class Card
    {
        public Suits suit;
        public Faces face;
        public int value;
        public string name;



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
        
        public int getValue()
        {
            value = (int)face;
            return value;
        }

       public string getName()
          {
            name = $"The {face} of {suit}s";
            return name;
        }
        
    }




}
