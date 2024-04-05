using GestionLivres.DTO.AutorDto;
using GestionLivres.DTO.BookDto;
using GestionLivres.DTO.BookDTO;
using GestionLivres.DTO.CategorieDTO;
using GestionLivres.Entities;
using GestionLivres.MediatorServices.Authors.GetAuthorQueryById;
using GestionLivres.MediatorServices.Books.AddBookCommand;
using GestionLivres.MediatorServices.Books.DeleteBookById;
using GestionLivres.MediatorServices.Books.GetAllBookQuery;
using GestionLivres.MediatorServices.Books.GetBookQueryById;
using GestionLivres.Services.Books;
using GestionLivres.Services.Categories;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionLivres.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private IMediator _mediator;
        public BookController(IMediator mediator) {
            _mediator = mediator;
        }


        [HttpPost]
        public async Task<ActionResult<GetBookDto>> AddBook(AddBookDto request)
        {
            AddBookCommand command = new AddBookCommand() { dto = request};
            var book = await _mediator.Send(command);
            return Ok(book);

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetBookDto>>> GetListBook()
        {
            var ListBook = await _mediator.Send(new GetAllBookQuery());
            return Ok(ListBook);

        }

        [HttpGet("id")]
        public async Task<ActionResult<GetBookByIdDto>> GetBookById(int id)
        {
            var book = await _mediator.Send(new GetBookQueryById(id));
            return book != null ? Ok(book) : NotFound();

        }

        [HttpDelete]
        public async Task<ActionResult<DeleteBookDto>> DeleteBook(int id)
        {
            var book = await _mediator.Send(new DeleteBookById(id));
            return book;

        }
    }
}
