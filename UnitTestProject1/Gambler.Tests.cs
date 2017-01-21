using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlackJack;

namespace GamblerTests
{
    [TestClass]
    public class GamblerTests
    {
        [TestMethod]
        public void GamblerAttainsAttributes()
        {
            var sut = new Gambler (2, 16);
            Assert.AreEqual(2, sut.getNumbofCards());
            Assert.AreEqual(16, sut.getHoldingValue());

        }
    }
}
