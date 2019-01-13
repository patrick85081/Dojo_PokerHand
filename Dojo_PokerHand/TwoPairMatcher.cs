using System.Collections.Generic;
using System.Linq;

namespace Dojo_PokerHand
{
    public class TwoPairMatcher : ICardTypeMatcher
    {
        public bool IsMatch(IEnumerable<Card> cards)
        {
            var groupByNumber = cards.GroupBy(c => c.Number);
            return groupByNumber.Count() == 3 && groupByNumber.Count(g => g.Count() == 2) == 2;
        }

        public CardType CardType => CardType.TwoPair;
    }
}