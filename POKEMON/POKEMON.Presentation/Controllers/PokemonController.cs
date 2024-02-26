using MediatR;
using Microsoft.AspNetCore.Mvc;
using POKEMON.Application.Pokemon.Command.AddPokemon;

namespace POKEMON.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PokemonController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<PokemonController>
        [HttpGet]
        public IEnumerable<string> GetAllPokemon()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PokemonController>/5
        [HttpGet("{id}")]
        public string GetPokemonById(int id)
        {
            return "value";
        }

        // POST api/<PokemonController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> AddPokemon([FromBody] AddPokemonCommand request)
        {
            return Ok(await _mediator.Send(request));
        }

        // PUT api/<PokemonController>/5
        [HttpPut("{id}")]
        public void UpdatePokemon(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PokemonController>/5
        [HttpDelete("{id}")]
        public void DeletePokemon(int id)
        {
        }
    }
}
