using GestionLivres.DTO.AutorDto;
using GestionLivres.DTO.BookDto;
using MediatR;

namespace GestionLivres.MediatorServices.Books.GetBookQueryById
{
    public class GetBookQueryById : IRequest<GetBookByIdDto>
    {
        public int id;
        public GetBookQueryById(int id) { this.id = id; }
    }
}
