using GestionLivres.DTO.BookDTO;
using GestionLivres.Entities;

namespace GestionLivres.DTO.CategorieDTO
{
    public class CategorieDetailDto
    {
        public int CategorieId { get; set; }
        public string libelle { get; set; }
        public string Description { get; set; }
        public ICollection <GetBookDto> Books { get; set; }
    }
}
