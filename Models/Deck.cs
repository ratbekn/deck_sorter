using System.Collections.Generic;

namespace DeckSorter.Models
{
    public class Deck
    {
        public string Name { get; }
        public IEnumerable<Card> Cards { get; }

        public Deck(string name, IEnumerable<Card> cards)
        {
            Name = name;
            Cards = cards;
        }
    }
}