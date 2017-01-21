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
        Two, Three, Four, Five, Six,
        Seven, Eight, Nine, Ten,
        Jack, Queen, King, Ace
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
            
            if (getFace() = Faces.Ace)
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
