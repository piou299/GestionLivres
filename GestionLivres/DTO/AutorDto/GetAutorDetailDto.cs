using GestionLivres.DTO.BookDTO;
using GestionLivres.Entities;

namespace GestionLivres.DTO.AutorDto
{
    public class GetAutorDetailDto
    {
        public int AutorId { get; set; }
        public string Name { get; set; }
        public ICollection­­­<GetBookDto> Books { get; set; }
    }
}
