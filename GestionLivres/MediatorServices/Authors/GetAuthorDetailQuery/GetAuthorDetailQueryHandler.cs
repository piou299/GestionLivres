using AutoMapper;
using GestionLivres.DTO.AutorDto;
using GestionLivres.Repository.Autors;
using MediatR;

namespace GestionLivres.MediatorServices.Authors.GetAuthorDetailQuery
{
    public class GetAuthorDetailQueryHandler : IRequestHandler<GetAuthorDetailQuery, GetAutorDetailDto>
    {
        private readonly IAutorRepository _repository;
        private readonly IMapper _mapper;
        public GetAuthorDetailQueryHandler(IAutorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<GetAutorDetailDto> Handle(GetAuthorDetailQuery request, CancellationToken cancellationToken)
        {
            var autor = _repository.GetAutorDetailRepository(request.id);
            var result = _mapper.Map<GetAutorDetailDto>(autor);
            return result;
        }
    }
}
