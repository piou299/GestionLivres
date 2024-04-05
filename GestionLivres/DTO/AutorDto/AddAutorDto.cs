using System.ComponentModel.DataAnnotations;

namespace GestionLivres.DTO.AutorDto
{
    public class AddAutorDto
    {
        [Required(ErrorMessage = "Veuillez saisir une valeur")]
        public string Name { get; set; }
    }
}
