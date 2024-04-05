using GestionLivres.DTO.BookDTO;
using MediatR;

namespace GestionLivres.MediatorServices.Books.GetAllBookQuery
{
    public class GetAllBookQuery : IRequest<IEnumerable<GetBookDto>>
    {
    }
}
