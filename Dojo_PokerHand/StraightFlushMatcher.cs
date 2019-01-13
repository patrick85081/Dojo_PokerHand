using System.Collections.Generic;
using System.Linq;

namespace Dojo_PokerHand
{
    public class StraightFlushMatcher : ICardTypeMatcher
    {
        public StraightFlushMatcher()
        {
        }

        public bool IsMatch(IEnumerable<Card> cards)
        {
            return new FlushMatcher().IsMatch(cards) && IsStraight(cards);
        }

        public CardType CardType => CardType.StraightFlush;

        private bool IsStraight(IEnumerable<Card> cards)
        {
            var isStraight = cards.GroupBy(c => c.Number).Count() == 5 &&
                             cards.Max(c => c.Number) - cards.Min(c => c.Number) == 4;
            return isStraight;
        }
    }
}