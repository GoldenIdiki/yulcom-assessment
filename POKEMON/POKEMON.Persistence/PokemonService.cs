using POKEMON.Application.Contract.Persistence;
using POKEMON.Application.Contract.Services;
using POKEMON.Domain.Entities;

namespace POKEMON.Persistence
{
    public class PokemonService : IPokemonService
    {
        private readonly IPokemonRepository _pokemonRepo;
        public PokemonService(IPokemonRepository pokemonRepository)
        {
            _pokemonRepo = pokemonRepository;
        }
        public async Task<bool> AddPokemon(Pokemon pokemon)
        {
            return await _pokemonRepo.AddAsync(pokemon);
        }

        public void DeletePokemon(Pokemon pokemon)
        {
            throw new NotImplementedException();
        }

        public void GetALl(Pokemon pokemon)
        {
            throw new NotImplementedException();
        }

        public void GetById(Pokemon pokemon)
        {
            throw new NotImplementedException();
        }

        public void UpdatePokemon(Pokemon pokemon)
        {
            throw new NotImplementedException();
        }
    }
}
