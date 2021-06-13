using System.Threading.Tasks;
using DeckSorter.Models;

namespace DeckSorter.Services
{
    public interface IDeckService
    {
        public Task<Deck> Create(string name);
    }
}