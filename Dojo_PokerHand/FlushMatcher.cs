using System.Collections.Generic;
using System.Linq;

namespace Dojo_PokerHand
{
    public class FlushMatcher : ICardTypeMatcher
    {
        public FlushMatcher()
        {
        }

        public bool IsMatch(IEnumerable<Card> cards)
        {
            var isFlush = cards.GroupBy(c => c.Suit).Count() == 1;
            return isFlush;
        }

        public CardType CardType => CardType.Flush;
    }
}