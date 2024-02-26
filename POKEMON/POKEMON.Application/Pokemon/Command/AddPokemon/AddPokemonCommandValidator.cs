using FluentValidation;

namespace POKEMON.Application.Pokemon.Command.AddPokemon
{
    public class AddPokemonCommandValidator : AbstractValidator<AddPokemonCommand>
    {
        public static AddPokemonCommandValidator Instance { get; } = new AddPokemonCommandValidator();
        private AddPokemonCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotNull()
                .NotEmpty()
                .WithMessage("Name is required");

            RuleFor(x => x.HP)
                .NotNull()
                .NotEmpty()
                .WithMessage("HP is required");

            RuleFor(x => x.TypeOne)
                .NotNull()
                .NotEmpty()
                .WithMessage("Type one is required");
                
            RuleFor(x => x.TypeTwo)
                .NotNull()
                .NotEmpty()
                .WithMessage("Type two is required");
        }
    }
}
