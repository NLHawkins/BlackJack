using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlackJack;
using System.Collections.Generic;

namespace CardFactoryTests
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestThatFullDeckofCardsISCreated()
        {
            var sut = CardFactory.CreateDeck();
            Assert.AreEqual(52, sut.Count);
        }

        [TestMethod]
        public void DeckContains13SuitedMacthes()
        {

            var sut = CardFactory.getSuitTestList();
            Assert.AreEqual(13, sut.Count);

        }

    }
}
