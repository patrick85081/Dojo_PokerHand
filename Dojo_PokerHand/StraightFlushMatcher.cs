using System.Collections.Generic;

namespace Dojo_PokerHand
{
    public class StraightFlushMatcher : ICardTypeMatcher
    {
        public StraightFlushMatcher()
        {
        }

        public bool IsMatch(IEnumerable<Card> cards)
        {
            return new FlushMatcher().IsMatch(cards) && new StraightMatcher().IsMatch(cards);
        }

        public CardType CardType => CardType.StraightFlush;
    }
}