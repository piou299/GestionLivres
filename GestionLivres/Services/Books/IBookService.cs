using GestionLivres.DTO.BookDTO;
using GestionLivres.DTO.CategorieDTO;
using GestionLivres.Entities;

namespace GestionLivres.Services.Books
{
    public interface IBookService
    {
        public Book AddBook(AddBookDto request);
        public IEnumerable<AddBookDto> GetBook();
        public Book GetBookById(int Id);
        public Book DeleteBookService(int Id);
    }
}
