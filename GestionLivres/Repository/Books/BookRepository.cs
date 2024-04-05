using GestionLivres.Datas;
using GestionLivres.Entities;
using Microsoft.EntityFrameworkCore;

namespace GestionLivres.Repository.Books
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationsContext _Context;
        public BookRepository(ApplicationsContext Context)
        {
            _Context = Context;
        }

        public void AddNewBook(Book book)
        {
            _Context.Books.Add(book);
            _Context.SaveChanges();
        }

        public Book DeleteBookrepository(int id)
        {
            var book = GetFirtBookById(id);
            _Context.Remove(book);
            _Context.SaveChanges();
            return book;
        }

        public IEnumerable<Book> GetAllBokk() => _Context.Books.Include(b => b.Categorie).Include(b => b.Autor);

        public Book GetFirtBookById(int id)
        {
            return _Context.Books.Find(id);
        }
    }
}
