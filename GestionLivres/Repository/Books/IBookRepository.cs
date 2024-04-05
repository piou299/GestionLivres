using GestionLivres.DTO.BookDTO;
using GestionLivres.Entities;

namespace GestionLivres.Repository.Books
{
    public interface IBookRepository
    {
        public void AddNewBook(Book book);
        public IEnumerable<Book> GetAllBokk();
        public Book GetFirtBookById(int id);
        public Book DeleteBookrepository(int id); 
    }
}
