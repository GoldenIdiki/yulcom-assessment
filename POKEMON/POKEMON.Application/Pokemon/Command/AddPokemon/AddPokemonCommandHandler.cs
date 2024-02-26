using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using POKEMON.Application.Contract.Services;
using entity = POKEMON.Domain.Entities;

namespace POKEMON.Application.Pokemon.Command.AddPokemon
{
    public class AddPokemonCommandHandler : IRequestHandler<AddPokemonCommand, AddPokemonCommandResponse>
    {
        private readonly ILogger<AddPokemonCommandHandler> _logger;
        private readonly IPokemonService _pokemanService;
        private readonly IMapper _mapper;
        public AddPokemonCommandHandler(ILogger<AddPokemonCommandHandler> logger, IPokemonService pokemonService, IMapper mapper)
        {
            _logger = logger;
            _pokemanService = pokemonService;
        }

        public async Task<AddPokemonCommandResponse> Handle(AddPokemonCommand request, CancellationToken cancellationToken)
        {
            var requestValidation = AddPokemonCommandValidator.Instance.Validate(request);
            if (!requestValidation.IsValid)
            {
                return new AddPokemonCommandResponse
                {
                    Message = "One or more validations failed",
                    ValidationErrors = requestValidation.Errors.Select(item => item.ErrorMessage).ToList()
                };
            }
            var response = new AddPokemonCommandResponse();
            var pokemon = _mapper.Map<entity.Pokemon>(request);
            

            var addPokemonRespponse = await _pokemanService.AddPokemon(pokemon);
            if (addPokemonRespponse == false)
            {
                response.Success = false;
                response.Message = "An error occurred while inserting the record";
                return response;
            }
            return new AddPokemonCommandResponse
            {
                Message = "The operation was successful",
                Success = addPokemonRespponse,
            };
        }
    }
}
