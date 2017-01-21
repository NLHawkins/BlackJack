using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlackJack;

namespace GamblerTests
{
    [TestClass]
    public class GamblerTests
    {
        Card testCard = new Card(Suits.Club, Faces.Ace);

        public void addtoHand(Gambler player)
        {

            player.hand.Add(testCard);
            player.handNameList.Add(testCard.getName());

        }

        [TestMethod]
        public void GamblerAttainsAttributes()
        {

            Gambler sut = new Gambler();
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

