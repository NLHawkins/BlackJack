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
                var card = GamePlay.DealCard();
                testCardMatchList.Add(card);                
            }

            var distinctTestList = testCardMatchList.Distinct();
            //var matches = testCardMatchList.Intersect(distinctTestList);
            Assert.AreEqual(testCardMatchList.Count(), distinctTestList.Count());
        }

        [TestMethod]
        public void GamePlayWillDeal13ofeachSuit()
        {
            List<Card> testCardMatchList = new List<Card>();
            for (int i = 0; i <= 52; i++)
            {
                var card = GamePlay.DealCard();
                testCardMatchList.Add(card);
            }

            var suitTestList = new List<Suits>();
            foreach (var card in testCardMatchList)
            {
                card.getSuit();
                suitTestList.Add(card.suit);
            }
            int count = suitTestList.FindAll(x => x == Suits.Club).Count();
            Assert.AreEqual(13, count);
        }
        [TestMethod]
        public void TestHand()
        {
            var testPlayer = new Gambler(null, 0, 0);
            testPlayer.AddCardToHand();
            Assert.IsNotNull(testPlayer.getHandList());
            Assert.AreEqual(1, testPlayer.getNumbofCards());
        }
    }
}
