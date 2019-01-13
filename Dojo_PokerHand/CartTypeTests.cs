﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dojo_PokerHand
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void Spade_9()
        {
            var card = new Card("S9");
            Assert.AreEqual(SuitType.Spade, card.Suit);
            Assert.AreEqual(9, card.Number);
        }

        [TestMethod]
        public void Heart_10()
        {
            var card = new Card("H10");
            Assert.AreEqual(SuitType.Heart, card.Suit);
            Assert.AreEqual(10, card.Number);
        }
    }
}