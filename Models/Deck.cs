using System.Collections.Generic;

namespace DeckSorter.Models
{
    public class Deck
    {
        public string Name { get; }
        public List<Card> Cards { get; }

        public Deck(string name, List<Card> cards)
        {
            Name = name;
            Cards = cards;
        }
    }
}