using System.Collections.Generic;
using System.Linq;

namespace Dojo_PokerHand.PokerHand.CardMatchers
{
    public class StraightMatcher : ICardTypeMatcher
    {
        public StraightMatcher()
        {
        }

        public bool IsMatch(IEnumerable<Card> cards)
        {
            var numbers = cards.Select(c => c.Number);
            var newNumbers = numbers.Select(n => n == 1 ? 14 : n);
            var isStraight = cards.GroupBy(c => c.Number).Count() == 5 &&
                             (IsMaxMinDifferentFour(numbers) ||
                              IsMaxMinDifferentFour(newNumbers));
            return isStraight;
        }

        private static bool IsMaxMinDifferentFour(IEnumerable<int> newNumbers)
        {
            return newNumbers.Max() - newNumbers.Min() == 4;
        }

        public CardType CardType => CardType.Straight;
    }
}