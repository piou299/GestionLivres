using AutoMapper;
using GestionLivres.DTO.AutorDto;
using GestionLivres.DTO.CategorieDto;
using GestionLivres.DTO.CategorieDTO;
using GestionLivres.Repository.Books;
using GestionLivres.Repository.Categories;
using MediatR;

namespace GestionLivres.MediatorServices.Categories.GetCategorieDetailQuery
{
    public class GetCategorieDetailQueryHandler : IRequestHandler<GetCategorieDetailQuery, CategorieDetailDto>
    {
        private readonly ICategorieRepository _repository;
        private readonly IMapper _mapper;
        public GetCategorieDetailQueryHandler(ICategorieRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<CategorieDetailDto> Handle(GetCategorieDetailQuery request, CancellationToken cancellationToken)
        {
            var categorie = _repository.GetFirtCategorieById(request.id);
            var result =  _mapper.Map<CategorieDetailDto>(categorie);
            return result;
        }
    }
}
