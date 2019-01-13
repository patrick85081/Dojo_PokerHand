using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dojo_PokerHand
{
    [TestClass]
    public class CardJudgeTest
    {
        [TestMethod]
        public void StraightFlush()
        {
            var cardJudge = new CardJudge("H4,H6,H5,H7,H8");
            Assert.AreEqual(CardType.StraightFlush, cardJudge.CardType);
        }
    }
}