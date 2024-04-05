using AutoMapper;
using GestionLivres.DTO.BookDTO;
using GestionLivres.DTO.CategorieDTO;
using GestionLivres.Entities;
using GestionLivres.Repository.Books;
using GestionLivres.Repository.Categories;

namespace GestionLivres.Services.Categories
{
    public class CategorieService : ICategorieService
    {
        private readonly ICategorieRepository _repository;
        private readonly IMapper _mapper;
        public CategorieService(ICategorieRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Categorie AddCategorie(AddCategorieDto request)
        {
            Categorie categorie = new Categorie()
            {
                libelle = request.libelle,
                Description = request.Description
            };
           _repository.AddNewCategorie(categorie);
            return categorie;
        }

        public IEnumerable<AddCategorieDto> GetCategorie()
        {
            var list = _repository.GetAllCategorie();

            var listResult = new List<AddCategorieDto>();

            foreach (var book in list)
            {
                listResult.Add(new AddCategorieDto { libelle = book.libelle });
            }
            return listResult;

        }

        public CategorieDetailDto GetCategorieById(int Id)
        {
            var categorie = _repository.GetFirtCategorieById(Id);
            var result = _mapper.Map<CategorieDetailDto>(categorie);
            return result;
        }
    }
}
