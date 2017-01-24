using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlackJack;

namespace CardTests
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void TestCardAttributes()
        {

            
            var sut = new Card(Suits.Club,Faces.Ace);
            Assert.AreEqual(Suits.Club, sut.getSuit());
            Assert.AreEqual(Faces.Ace, sut.getFace());
            Assert.AreEqual(11, sut.getValue());
            Assert.AreEqual("The Ace of Clubs", sut.getName());
            
        }

       
    }
}
