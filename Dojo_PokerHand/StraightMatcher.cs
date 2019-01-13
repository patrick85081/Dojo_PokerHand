using System.Collections.Generic;
using System.Linq;

namespace Dojo_PokerHand
{
    public class StraightMatcher : ICardTypeMatcher
    {
        public StraightMatcher()
        {
        }

        public bool IsMatch(IEnumerable<Card> cards)
        {
            var isStraight = cards.GroupBy(c => c.Number).Count() == 5 &&
                             cards.Max(c => c.Number) - cards.Min(c => c.Number) == 4;
            return isStraight;
        }

        public CardType CardType => CardType.Straight;
    }
}