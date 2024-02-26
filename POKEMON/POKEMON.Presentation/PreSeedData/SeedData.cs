using CsvHelper;
using POKEMON.Application.Contract.Persistence;
using POKEMON.Domain.Entities;
using POKEMON.Persistence;
using System.Globalization;
using System.Net;

namespace POKEMON.Presentation.PreSeedData
{
    public class SeedData
    {
        private readonly IPokemonRepository _pokemonRepo;
        private readonly AppDbContext _appDbContext;
        public SeedData(IPokemonRepository pokemonRepo, AppDbContext appDbContext)
        {
            _pokemonRepo = pokemonRepo;
            _appDbContext = appDbContext;
        }

        public void PreSeed(List<Pokemon> pokemons)
        {
            if (!_appDbContext.Pokemons.Any())
            {
                _pokemonRepo.AddRange(pokemons);
            }
        }

        public static void ReadCSVFile(string url)
        {
            List<Pokemon> data = null;
            HttpWebRequest? request = WebRequest.Create(url) as HttpWebRequest;
            HttpWebResponse? response = request.GetResponse() as HttpWebResponse;

            using (var reader = new StreamReader(response.GetResponseStream()))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<PreseedPokemonMap>();
                var records = csv.GetRecords<Pokemon>().ToList();
                data = records;
            }
        }
    }
}
