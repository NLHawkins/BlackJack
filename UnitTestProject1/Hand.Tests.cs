using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlackJack;

namespace HandTests
{
    [TestClass]
    public class HandTests
    {
        Card testCard = new Card(Suits.Club, Faces.Ace);

        public void addtoHand(Hand player)
        {

            player.hand.Add(testCard);
            player.handNameList.Add(testCard.getName());

        }

        [TestMethod]
        public void HandAttainsAttributes()
        {

            Hand sut = new Hand();
            Card testCard = new Card(Suits.Club, Faces.Ace);
            Card testCard2 = new Card(Suits.Diamond, Faces.Five);
            sut.hand.Add(testCard);
            sut.hand.Add(testCard2);
            sut.handNameList.Add(testCard.getName());
            sut.handNameList.Add(testCard2.getName());
            Assert.AreEqual(2, sut.getNumbofCards());
            Assert.AreEqual(16, sut.getHoldingValue());
        }
    }
}

