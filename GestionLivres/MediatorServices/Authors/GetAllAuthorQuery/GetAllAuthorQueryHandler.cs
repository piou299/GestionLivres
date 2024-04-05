using AutoMapper;
using GestionLivres.DTO.AutorDto;
using GestionLivres.DTO.CategorieDto;
using GestionLivres.Entities;
using GestionLivres.Repository.Autors;
using MediatR;

namespace GestionLivres.MediatorServices.Authors.Requests
{
    public class GetAllAuthorQueryHandler : IRequestHandler<GetAllAuthorQuery, IEnumerable<GetAutorDto>>
    {
        private readonly IAutorRepository _repository;
        private readonly IMapper _mapper;
        public GetAllAuthorQueryHandler(IAutorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetAutorDto>> Handle(GetAllAuthorQuery request, CancellationToken cancellationToken)
        {
              var list = _repository.GetAutorRepository();
            var result = _mapper.Map<IEnumerable<GetAutorDto>>(list);
            return await Task.FromResult(result);
        }
    }
}
 