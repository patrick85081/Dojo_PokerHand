using Dojo_PokerHand.PokerHand;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dojo_PokerHand
{
    [TestClass]
    public class CardTypeCompareTest
    {
        [TestMethod]
        public void CardType_Compare()
        {
            Assert.AreEqual(true, CardType.StraightFlush > CardType.FourOfAKind);
            Assert.AreEqual(true, CardType.FourOfAKind > CardType.FullHouse);
            Assert.AreEqual(true, CardType.FullHouse > CardType.Flush);
            Assert.AreEqual(true, CardType.Flush > CardType.Straight);
            Assert.AreEqual(true, CardType.Straight > CardType.ThreeOfAKind);
            Assert.AreEqual(true, CardType.ThreeOfAKind > CardType.TwoPair);
            Assert.AreEqual(true, CardType.TwoPair > CardType.HighCard);
        }
    }
}