using System.Collections.Generic;
using System.Linq;

namespace Dojo_PokerHand
{
    public class ThreeOfAKindMatcher : ICardTypeMatcher
    {
        public bool IsMatch(IEnumerable<Card> cards)
        {
            return cards.GroupBy(c => c.Number).Any(g => g.Count() == 3);
        }

        public CardType CardType => CardType.ThreeOfAKind;
    }
}