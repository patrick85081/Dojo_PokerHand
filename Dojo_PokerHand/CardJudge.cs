using System.Collections.Generic;
using System.Linq;

namespace Dojo_PokerHand
{
    public class CardJudge
    {
        private IReadOnlyList<Card> cards;

        public CardJudge(string cardString)
        {
            cards = cardString.Split(',')
                .Select(s => new Card(s))
                .ToList()
                .AsReadOnly();
            Judge(cards);
        }

        private void Judge(IEnumerable<Card> cards)
        {
            if (IsFlush(cards) && IsStraight(cards))
            {
                CardType = CardType.StraightFlush;
            }
        }

        private bool IsStraight(IEnumerable<Card> cards)
        {
            var isStraight = cards.GroupBy(c => c.Number).Count() == 5 &&
                             cards.Max(c => c.Number) - cards.Min(c => c.Number) == 4;
            return isStraight;
        }

        private bool IsFlush(IEnumerable<Card> cards)
        {
            var isFlush = cards.GroupBy(c => c.Suit).Count() == 1;
            return isFlush;
        }

        public CardType CardType { get; private set; }
    }
}