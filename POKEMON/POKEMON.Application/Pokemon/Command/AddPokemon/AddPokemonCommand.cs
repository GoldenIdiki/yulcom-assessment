using MediatR;

namespace POKEMON.Application.Pokemon.Command.AddPokemon
{
    public class AddPokemonCommand : IRequest<AddPokemonCommandResponse>
    {
        public string Name { get; set; }
        public string TypeOne { get; set; }
        public string TypeTwo { get; set; }
        public int Total { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpeedAttack { get; set; }
        public int SpeedDefense { get; set; }
        public int Speed { get; set; }
        public int Generation { get; set; }
        public bool Legendary { get; set; }
    }
}
