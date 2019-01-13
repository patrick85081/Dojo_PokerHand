using System.Collections.Generic;
using System.Linq;

namespace Dojo_PokerHand.PokerHand.CardMatchers
{
    public class FourOfAKindMatcher : ICardTypeMatcher
    {
        public FourOfAKindMatcher()
        {
        }

        public bool IsMatch(IEnumerable<Card> cards)
        {
            var isFourOfAKind = cards.GroupBy(c => c.Number).Any(g => g.Count() == 4);
            return isFourOfAKind;
        }

        public CardType CardType => CardType.FourOfAKind;
    }
}