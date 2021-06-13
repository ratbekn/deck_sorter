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
        private readonly IShuffler deckShuffler;

        public DeckService(IDeckRepository deckRepository, IShuffler deckShuffler)
        {
            this.deckRepository = deckRepository;
            this.deckShuffler = deckShuffler;
        }

        public async Task<Deck> Create(string name)
        {
            var cards = (from suit in (CardSuit[]) Enum.GetValues(typeof(CardSuit)) 
                         from rank in (CardRank[]) Enum.GetValues(typeof(CardRank)) 
                         select new Card(rank, suit)).ToList();

            var newDeck = new Deck(name, cards);
            
            await deckRepository.Insert(newDeck);

            return newDeck;
        }

        public async Task<Deck?> Find(string name)
        {
            return await deckRepository.Find(name);
        }

        public async Task Delete(string name)
        {
            await deckRepository.Delete(name);
        }

        public async Task<string[]> GetAllNames()
        {
            return await deckRepository.GetAllNames();
        }

        public void ShuffleDeck(Deck deck)
        {
            deckShuffler.Shuffle(deck.Cards);

            deckRepository.Insert(deck);
        }
    }
}