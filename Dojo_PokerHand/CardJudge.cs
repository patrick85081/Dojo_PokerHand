using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Dojo_PokerHand
{
    public class CardJudge
    {
        private IReadOnlyList<Card> cards;

        private static readonly List<ICardTypeMatcher> TypeMatchers = new List<ICardTypeMatcher>()
        {
            new StraightFlushMatcher(),
            new FourOfAKindMatcher(),
            new FullHouseMatcher(),
            new FlushMatcher(),
            new StraightMatcher(),
            new ThreeOfAKindMatcher(),
            new TwoPairMatcher(),
            new OnePairMatcher(),
            new HighCardMatcher(),
        };

        public CardType CardType { get; private set; }

        public CardJudge(string cardString)
        {
            cards = ParserCardString(cardString);
            Judge(cards);
        }

        private static ReadOnlyCollection<Card> ParserCardString(string cardString)
        {
            return cardString.Split(',')
                .Select(s => new Card(s))
                .ToList()
                .AsReadOnly();
        }

        private void Judge(IEnumerable<Card> cards)
        {
            foreach (var typeMatcher in TypeMatchers)
            {
                if (typeMatcher.IsMatch(cards))
                {
                    CardType = typeMatcher.CardType;
                    break;
                }
            }
        }
    }
}