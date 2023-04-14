
using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Dto;
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

        [HttpGet("{pokeId}")]
        [ProducesResponseType(200, Type = typeof(Pokemon))]
        [ProducesResponseType(400)]
        public IActionResult GetPokemon(int pokeId) {

            if (!_pokemonRepository.PokemonExists(pokeId))
                return NotFound();
          var pokemon = _pokemonRepository.GetPokemon(pokeId);
            return Ok(pokemon);
        }

        [HttpGet("{pokeId/rating}")]
        [HttpGet("{pokeId}")]
        [ProducesResponseType(200, Type = typeof(decimal))]
        [ProducesResponseType(400)]

        public IActionResult GetPokemonRating(int pokeId)
        {
            if(!_pokemonRepository.PokemonExists(pokeId))
                return NotFound();
            var rating = _pokemonRepository.GetPokemonRating(pokeId);
            if (!ModelState.IsValid)
                return BadRequest();
            return Ok(rating);
        }

    }
}
