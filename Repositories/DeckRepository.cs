using System.Collections.Generic;
using System.Threading.Tasks;
using DeckSorter.Models;

namespace DeckSorter.Repositories
{
    public class DeckRepository : IDeckRepository
    {
        private readonly Dictionary<string, Deck> store = new();
        
        public async Task Insert(Deck deck)
        {
            await Task.Run(() => store[deck.Name] = deck);
        }
    }
}