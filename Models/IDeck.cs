using System.Collections.Generic;

namespace DeckSorter.Models
{
    public interface IDeck<T> where T : ICard
    {
        public string Name { get; }
        public IEnumerable<T> Cards { get; }
    }
}