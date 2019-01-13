using System.Collections.Generic;

namespace Dojo_PokerHand
{
    public interface ICardTypeMatcher
    {
        bool IsMatch(IEnumerable<Card> cards);
        CardType CardType { get; }
    }
}