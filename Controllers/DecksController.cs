using System.Threading.Tasks;
using DeckSorter.Models;
using DeckSorter.Services;
using Microsoft.AspNetCore.Mvc;

namespace DeckSorter.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DecksController : ControllerBase
    {
        private readonly IDeckService deckService;

        public DecksController(IDeckService deckService)
        {
            this.deckService = deckService;
        }
        
        [HttpPost]
        public async Task<ActionResult<Deck>> Create(string name)
        {
            var newDeck = await deckService.Create(name);

            return Created($"/decks/{name}", newDeck);
        }
    }
}