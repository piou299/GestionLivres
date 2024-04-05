using AutoMapper;
using GestionLivres.DTO.AutorDto;
using GestionLivres.DTO.CategorieDto;
using GestionLivres.Entities;
using GestionLivres.MediatorServices.Authors.Requests;
using GestionLivres.Repository.Books;
using GestionLivres.Repository.Categories;
using MediatR;

namespace GestionLivres.MediatorServices.Categories.GetAllCategorieQuery
{
    public class GetAllCategorieQueryHandler : IRequestHandler<GetAllCategorieQuery, IEnumerable<GetCategorieDto>>
    {
        private readonly ICategorieRepository _repository;
        private readonly IMapper _mapper;
        public GetAllCategorieQueryHandler(ICategorieRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public Task<IEnumerable<GetCategorieDto>> Handle(GetAllCategorieQuery request, CancellationToken cancellationToken)
        {
           var categories = _repository.GetAllCategorie();
            var result = _mapper.Map<IEnumerable<GetCategorieDto>>(categories);
            return Task.FromResult(result);
        }
    }
}
