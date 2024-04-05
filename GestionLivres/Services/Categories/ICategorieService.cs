using GestionLivres.DTO.CategorieDTO;
using GestionLivres.Entities;

namespace GestionLivres.Services.Categories
{
    public interface ICategorieService
    {
        public Categorie AddCategorie(AddCategorieDto request);
        public IEnumerable<AddCategorieDto> GetCategorie();
        public CategorieDetailDto GetCategorieById(int Id);
    }
}
