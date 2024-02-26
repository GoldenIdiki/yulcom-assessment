using entity = POKEMON.Domain.Entities;

namespace POKEMON.Application.Contract.Persistence
{
    public interface IPokemonRepository
    {
        Task<entity.Pokemon> GetByIdAsync(int id);

        Task<List<entity.Pokemon>> GetAllAsync();

        Task<bool> AddAsync(entity.Pokemon entity);
        Task<bool> AddRange(List<entity.Pokemon> entity);

        Task<bool> UpdateAsync(entity.Pokemon entity);

        Task<bool> DeleteAsync(entity.Pokemon entity);
    }
}
