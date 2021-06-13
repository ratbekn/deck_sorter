using System.Collections.Generic;

namespace DeckSorter.Models
{
    public class Deck
    {
        private string name;
        private IEnumerable<Card> cards;

        public Deck(string name, IEnumerable<Card> cards)
        {
            this.name = name;
            this.cards = cards;
        }
    }
}