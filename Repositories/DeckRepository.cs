using System.Collections.Generic;
using System.Linq;
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

        public async Task<Deck?> Find(string name)
        {
            return await Task.Run(() => store.TryGetValue(name, out var deck) ? deck : null);
        }

        public async Task Delete(string name)
        {
            await Task.Run(() => store.Remove(name));
        }

        public async Task<string[]> GetAllNames()
        {
            return await Task.Run(() => store.Keys.ToArray());
        }
    }
}