using System.Collections.Generic;

namespace Dojo_PokerHand.PokerHand.CardMatchers
{
    public class HighCardMatcher : ICardTypeMatcher
    {
        public bool IsMatch(IEnumerable<Card> cards)
        {
            return true;
        }

        public CardType CardType => CardType.HighCard;
    }
}