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

            List<Faces> faceList = new List<Faces>()
                    {
                        Faces.Two, Faces.Three, Faces.Four,
                        Faces.Five,Faces.Six, Faces.Seven,
                        Faces.Eight, Faces.Nine, Faces.Ten,
                        Faces.Jack, Faces.Queen, Faces.King, Faces.Ace
                    };


            List<int> valueList = new List<int>() { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11 };

            int valueIndex = faceList.FindIndex(x => x.Equals(face));
            value = valueList[valueIndex];
            return value;
        }

        public string getName()
          {
            name = $"The {face} of {suit}s";
            return name;
        }
        
    }




}
