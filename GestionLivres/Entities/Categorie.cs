using System.ComponentModel.DataAnnotations;

namespace GestionLivres.Entities
{
    public class Categorie
    {
        [Key]
        public int CategorieId { get; set; }
        public string libelle { get; set; }
        public string Description { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
