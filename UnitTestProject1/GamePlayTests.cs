using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlackJack;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class GamePlayTests
    {
       
        [TestMethod]
        public void GamePlayWillDealUniqueCard()
        {
            List<Card> testCardMatchList = new List<Card>();
            
            for (int i = 0; i <= 52; i++)
            {
                var card = GamePlay.dealCard();
                testCardMatchList.Add(card);                
            }

            var distinctTestList = testCardMatchList.Distinct();
            //var matches = testCardMatchList.Intersect(distinctTestList);
            Assert.AreEqual(testCardMatchList.Count(), distinctTestList.Count());
        }

        [TestMethod]
        public void GamePlayWillDeal13ofeachSuit()
        {
            List<Card> testCardMatchList = CardFactory.CreateDeck();
            var suitTestList = new List<Suits>();
            foreach (var card in testCardMatchList)
            {
                card.getSuit();
                suitTestList.Add(card.suit);
            }
            int count = suitTestList.FindAll(x => x == Suits.Club).Count();
            Assert.AreEqual(13, count);
        }
        
    }
}
