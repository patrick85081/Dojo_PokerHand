using System.Collections.Generic;

namespace Dojo_PokerHand.PokerHand.CardMatchers
{
    public interface ICardTypeMatcher
    {
        bool IsMatch(IEnumerable<Card> cards);
        CardType CardType { get; }
    }
}