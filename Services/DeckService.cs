using System;
using System.Linq;
using System.Threading.Tasks;
using DeckSorter.Models;
using DeckSorter.Repositories;

namespace DeckSorter.Services
{
    public class DeckService : IDeckService
    {
        private readonly IDeckRepository deckRepository;

        public DeckService(IDeckRepository deckRepository)
        {
            this.deckRepository = deckRepository;
        }

        public async Task<Deck> Create(string name)
        {
            var cards = from suit in (CardSuit[]) Enum.GetValues(typeof(CardSuit)) 
                from rank in (CardRank[]) Enum.GetValues(typeof(CardRank)) 
                select new Card(rank, suit);

            var newDeck = new Deck(name, cards);
            
            await deckRepository.Insert(newDeck);

            return newDeck;
        }

        public async Task<Deck?> Find(string name)
        {
            return await deckRepository.Find(name);
        }
    }
}