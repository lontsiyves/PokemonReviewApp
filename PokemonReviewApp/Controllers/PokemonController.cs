
using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController: Controller
    {
        private readonly IpokemonRepository _pokemonRepository;
        public PokemonController(IpokemonRepository  pokemonRepository)
        {
            _pokemonRepository = pokemonRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type= typeof(IEnumerable<Pokemon>))]

        public IActionResult getPokemon()
        {
            var pokemons = _pokemonRepository.GetPokemons();
            return Ok(pokemons);
        }
    }
}
