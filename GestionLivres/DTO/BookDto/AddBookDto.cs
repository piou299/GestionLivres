
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionLivres.DTO.BookDTO
{
    public class AddBookDto
    {
        [Required(ErrorMessage = "Veuillez saisir un titre")]
        public string Title { get; set;}
        [Required(ErrorMessage = "Veuillez saisir une categorie")]
        public int CategorieId { get; set;}
        [Required(ErrorMessage = "Veuillez saisir un auteur")]
        public int AutorId { get; set;}
    }
}
