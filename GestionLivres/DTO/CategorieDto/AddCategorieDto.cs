using System.ComponentModel.DataAnnotations;

namespace GestionLivres.DTO.CategorieDTO
{
    public class AddCategorieDto
    {
        [Required(ErrorMessage = "Veuillez saisir une valeur")]
        public string libelle { get; set; }
        public string Description { get; set; }
    }
}
