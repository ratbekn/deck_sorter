using System;
using System.Collections.Generic;

namespace DeckSorter.Services
{
    public class SimpleShuffler : IShuffler
    {
        private readonly Random random = new Random();
        
        public void Shuffle<T>(List<T> collection)
        {
            for (var i = collection.Count - 1; i > 0; i--)
            {
                var j = random.Next(1, i);
                var temporary = collection[i];
                collection[i] = collection[j];
                collection[j] = temporary;
            }
        }
    }
}