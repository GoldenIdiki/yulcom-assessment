using CsvHelper.Configuration;
using POKEMON.Domain.Entities;

namespace POKEMON.Presentation.PreSeedData
{
    public class PreseedPokemonMap : ClassMap<Pokemon>
    {
        public PreseedPokemonMap()
        {
            Map(p => p.Id).Name("#");
            Map(p => p.Name).Name("Name");
            Map(p => p.TypeOne).Name("Type 1");
            Map(p => p.TypeTwo).Name("Type 2");
            Map(p => p.Total).Name("Total");
            Map(p => p.HP).Name("HP");
            Map(p => p.Attack).Name("Attack");
            Map(p => p.Defense).Name("Defense");
            Map(p => p.SpeedAttack).Name("Sp. Atk");
            Map(p => p.SpeedDefense).Name("Sp. Def");
            Map(p => p.Speed).Name("Speed");
            Map(p => p.Generation).Name("Generation");
            Map(p => p.Legendary).Name("Legendary");
        }
    }
}
