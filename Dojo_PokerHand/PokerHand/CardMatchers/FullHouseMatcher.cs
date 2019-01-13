using System.Collections.Generic;
using System.Linq;

namespace Dojo_PokerHand.PokerHand.CardMatchers
{
    public class FullHouseMatcher : ICardTypeMatcher
    {
        public bool IsMatch(IEnumerable<Card> cards)
        {
            var groupByNumber = cards.GroupBy(c=>c.Number);
            return groupByNumber.Count() == 2 && groupByNumber.Any(g => g.Count() == 3);
        }

        public CardType CardType => CardType.FullHouse;
    }
}