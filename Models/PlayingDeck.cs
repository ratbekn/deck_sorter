using System.Collections.Generic;

namespace DeckSorter.Models
{
    public class PlayingDeck : IDeck<PlayingCard>
    {
        public string Name { get; }
        public IEnumerable<PlayingCard> Cards { get; }
    }
}