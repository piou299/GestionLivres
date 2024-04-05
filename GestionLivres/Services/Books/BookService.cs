using GestionLivres.DTO.BookDTO;
using GestionLivres.Entities;
using GestionLivres.Repository.Books;
using Microsoft.AspNetCore.Mvc;

namespace GestionLivres.Services.Books
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _repository;
        public BookService(IBookRepository repository)
        {
            _repository = repository;
        }
        public Book AddBook(AddBookDto request)
        {
            Book book = new Book()
            {
                Title = request.Title,
                AutorId = request.AutorId,
                CategorieId = request.CategorieId
            };
            _repository.AddNewBook(book);
            return book;
        }

        public Book DeleteBookService(int Id)
        {
            var book = _repository.DeleteBookrepository(Id);
            return book;
           
        }

        public IEnumerable<AddBookDto> GetBook()
        {
            var list = _repository.GetAllBokk();

            var listResult = new List<AddBookDto>();

            foreach (var book in list)
            {
                listResult.Add(new AddBookDto { Title = book.Title, CategorieId = book.CategorieId, AutorId = book.AutorId });
            }
            return listResult;
        }

        public Book GetBookById(int Id)
        {
            var book = _repository.GetFirtBookById(Id); return book;
        }
    }
}
