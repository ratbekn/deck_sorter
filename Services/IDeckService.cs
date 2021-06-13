using System.Threading.Tasks;
using DeckSorter.Models;

namespace DeckSorter.Services
{
    public interface IDeckService
    {
        public Task<Deck> Create(string name);
        public Task<Deck?> Find(string name);
        public Task Delete(string name);
    }
}