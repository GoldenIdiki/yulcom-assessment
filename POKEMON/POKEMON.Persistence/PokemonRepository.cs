using Microsoft.EntityFrameworkCore;
using POKEMON.Application.Contract.Persistence;
using POKEMON.Domain.Entities;

namespace POKEMON.Persistence
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly AppDbContext _dbContext;
        public PokemonRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> AddAsync(Pokemon entity)
        {
            await _dbContext.AddAsync(entity);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> AddRange(List<Pokemon> entity)
        {
            await _dbContext.AddRangeAsync(entity);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteAsync(Pokemon entity)
        {
            _dbContext.Remove(entity);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<List<Pokemon>> GetAllAsync()
        {
            return await _dbContext.Pokemons.ToListAsync();
        }

        public async Task<Pokemon> GetByIdAsync(int id)
        {
            return await _dbContext.Pokemons.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<bool> UpdateAsync(Pokemon entity)
        {
            _dbContext.Pokemons.Update(entity);
            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}
