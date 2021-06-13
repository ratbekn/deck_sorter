using System.Threading.Tasks;
using DeckSorter.Models;

namespace DeckSorter.Repositories
{
    public interface IDeckRepository
    {
        public Task Insert(Deck deck);
        public Task<Deck?> Find(string name);
    }
}