using GestionLivres.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionLivres.DTO.BookDTO
{
    public class GetBookDto
    {
        public string Title { get; set; }
        public int CategorieId { get; set; }
        public int AutorId { get; set; }
    }
}
