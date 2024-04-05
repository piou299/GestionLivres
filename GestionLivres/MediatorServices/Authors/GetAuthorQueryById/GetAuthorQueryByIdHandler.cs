using AutoMapper;
using GestionLivres.DTO.AutorDto;
using GestionLivres.Repository.Autors;
using MediatR;

namespace GestionLivres.MediatorServices.Authors.GetAuthorQueryById
{
    public class GetAuthorQueryByIdHandler : IRequestHandler<GetAuthorQueryById, GetAutorByIdDto>
    {
        private readonly IAutorRepository _repository;
        private readonly IMapper _mapper;
        public GetAuthorQueryByIdHandler(IAutorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetAutorByIdDto> Handle(GetAuthorQueryById request, CancellationToken cancellationToken)
        {
            var autor = _repository.GetAutorRepositoryById(request.id);
            var result = _mapper.Map<GetAutorByIdDto>(autor);
            return result;
        }
    }
}
