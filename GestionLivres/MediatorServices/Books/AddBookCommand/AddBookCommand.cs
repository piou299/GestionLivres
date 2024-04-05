using GestionLivres.DTO.AutorDto;
using GestionLivres.DTO.BookDTO;
using MediatR;

namespace GestionLivres.MediatorServices.Books.AddBookCommand
{
    public class AddBookCommand : IRequest<GetBookDto>
    {
        public AddBookDto dto { get; set; }
    }
}
