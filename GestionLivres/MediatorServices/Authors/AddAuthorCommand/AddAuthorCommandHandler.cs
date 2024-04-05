using AutoMapper;
using GestionLivres.DTO.AutorDto;
using GestionLivres.Entities;
using GestionLivres.Repository.Autors;
using MediatR;

namespace GestionLivres.MediatorServices.Authors.AuthorCommands
{
    public class AddAuthorCommandHandler : IRequestHandler<AddAuthorCommand, GetAutorDto>
    {
        private readonly IAutorRepository _repository;
        private readonly IMapper _mapper;
        public AddAuthorCommandHandler(IAutorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<GetAutorDto> Handle(AddAuthorCommand request, CancellationToken cancellationToken)
        {
            var author = _mapper.Map<Autor>(request.dto);
            _repository.AddAutorRepository(author);

            var getAutorDto = _mapper.Map<GetAutorDto>(author);
            return getAutorDto;
        }
    }
}
