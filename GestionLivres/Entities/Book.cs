using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestionLivres.Entities
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        public int AutorId { get; set; }
        [ForeignKey(nameof(AutorId))]
        public virtual Autor Autor { get; set; }
        public int CategorieId { get; set; }
        [ForeignKey(nameof(CategorieId))]
        public virtual Categorie Categorie { get; set; }
    }
}
