using System.Collections.Generic;
using System.Linq;

namespace Dojo_PokerHand
{
    public class Card
    {
        private Dictionary<char, SuitType> suitTypes = new Dictionary<char, SuitType>
        {
            {'S', SuitType.Spade},
            {'H', SuitType.Heart},
            {'D', SuitType.Diamond},
            {'C', SuitType.Club},
        };

        private Dictionary<string, int> numberLookup = new Dictionary<string, int>()
        {
            {"J", 11},
            {"Q", 12},
        };

        public Card(string cardString)
        {
            var upper = cardString.ToUpper();
            Suit = suitTypes[upper.First()];
            Number = int.TryParse(upper.Substring(1), out var result) ? result : numberLookup[upper.Substring(1)];
        }

        public SuitType Suit { get; }
        public int Number { get; }
    }
}