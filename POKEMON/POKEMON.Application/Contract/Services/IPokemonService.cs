using entity = POKEMON.Domain.Entities;

namespace POKEMON.Application.Contract.Services
{
    public interface IPokemonService
    {
        Task<bool> AddPokemon(entity.Pokemon pokemon);
        void GetById(entity.Pokemon pokemon);
        void GetALl(entity.Pokemon pokemon);
        void UpdatePokemon(entity.Pokemon pokemon);
        void DeletePokemon(entity.Pokemon pokemon);
    }
}
