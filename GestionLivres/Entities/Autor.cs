using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestionLivres.Entities
{
    public class Autor
    {
        [Key]
        public int AutorId { get; set; }
        public string Name { get; set; }
        public ICollection­­­<Book> Books { get; set; }
    }
}
