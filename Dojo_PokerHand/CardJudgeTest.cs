using Dojo_PokerHand.PokerHand;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dojo_PokerHand
{
    [TestClass]
    public class CardJudgeTest
    {
        private readonly CardTypeCompareTest cardTypeCompareTest = new CardTypeCompareTest();

        [TestMethod]
        public void StraightFlush()
        {
            var cardJudge = new CardJudge("H4,H6,H5,H7,H8");
            Assert.AreEqual(CardType.StraightFlush, cardJudge.CardType);
        }

        [TestMethod]
        public void FourOfAKind()
        {
            var cardJudge = new CardJudge("C5,D5,H5,S5,H3");
            Assert.AreEqual(CardType.FourOfAKind, cardJudge.CardType);
        }

        [TestMethod]
        public void FullHouse()
        {
            var cardJudge = new CardJudge("HK,DK,SK,H5,S5");
            Assert.AreEqual(CardType.FullHouse, cardJudge.CardType);
        }

        [TestMethod]
        public void Flush()
        {
            var cardJudge = new CardJudge("HK,H3,H2,H5,H4");
            Assert.AreEqual(CardType.Flush, cardJudge.CardType);
        }

        [TestMethod]
        public void Straight()
        {
            var cardJudge = new CardJudge("S6,H3,H2,H5,H4");
            Assert.AreEqual(CardType.Straight, cardJudge.CardType);
        }

        [TestMethod]
        public void ThreeOfAKind()
        {
            var cardJudge = new CardJudge("HQ,SQ,DQ,H5,D9");
            Assert.AreEqual(CardType.ThreeOfAKind, cardJudge.CardType);
        }

        [TestMethod]
        public void TwoPair()
        {
            var cardJudge = new CardJudge("HA,DA,H9,D9,S4");
            Assert.AreEqual(CardType.TwoPair, cardJudge.CardType);
        }

        [TestMethod]
        public void OnePair()
        {
            var cardJudge = new CardJudge("HA,DA,H9,D7,S4");
            Assert.AreEqual(CardType.OnePair, cardJudge.CardType);
        }

        [TestMethod]
        public void HighCard()
        {
            var cardJudge = new CardJudge("HA,D7,H4,D8,S2");
            Assert.AreEqual(CardType.HighCard, cardJudge.CardType);
        }
    }
}