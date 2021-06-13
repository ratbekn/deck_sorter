using System.Collections.Generic;

namespace DeckSorter.Services
{
    public interface IShuffler
    {
        public void Shuffle<T>(List<T> collection);
    }
}