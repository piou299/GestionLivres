using GestionLivres.DTO.BookDto;
using MediatR;

namespace GestionLivres.MediatorServices.Books.DeleteBookById
{
    public class DeleteBookById : IRequest<DeleteBookDto>
    {
        public int id;
        public DeleteBookById (int id)
        {
            this.id = id;
        }
    }
}
