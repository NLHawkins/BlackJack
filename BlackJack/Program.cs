﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        Gambler player = new Gambler();
        Gambler dealer = new Gambler();
        List<Card> gameDeck = CardFactory.CreateDeck();
        Card card = new Card();
        Random rng = new Random();

        public Card dealCard()
        {
            while (gameDeck.Contains(card))
            {
                card = gameDeck[rng.Next(52)];
            }
            gameDeck.Remove(card);
            return card;
        }

        public void addtoHand(Gambler player)
        {
            var card = dealCard();
            player.hand.Add(card);
            player.handNameList.Add(card.getName());

        }

        static void Main(string[] args)
        {
            //var cardAtPlay = new Card();
           //cardAtPlay = GamePlay.dealCard();
            //player.hand.Add()

      
                    
            

            
            
            


            

            
           /* while(stand == false)
            {
                //player.AddCardToHand();
                //player.AddCardToHand();
               // Console.WriteLine(player.getHandList());



            }
            */

        }
    }
}
