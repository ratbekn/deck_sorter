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

        [HttpGet("{name}")]
        public async Task<ActionResult<Deck>> Find(string name)
        {
            var deck = await deckService.Find(name);

            if (deck == null)
            {
                return NotFound();
            }

            return Ok(deck);
        }

        [HttpDelete("{name}")]
        public async Task<ActionResult> Delete(string name)
        {
            await deckService.Delete(name);

            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<string[]>> GetAllNames()
        {
            return await deckService.GetAllNames();
        }
    }
}