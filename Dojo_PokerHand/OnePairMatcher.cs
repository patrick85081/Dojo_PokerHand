using System.Collections.Generic;
using System.Linq;

namespace Dojo_PokerHand
{
    public class OnePairMatcher : ICardTypeMatcher
    {
        public bool IsMatch(IEnumerable<Card> cards)
        {
            return cards.GroupBy(c => c.Number).Count() == 4;
        }

        public CardType CardType => CardType.OnePair;
    }
}