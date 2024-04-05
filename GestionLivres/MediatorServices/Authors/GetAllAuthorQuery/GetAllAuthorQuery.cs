using GestionLivres.DTO.AutorDto;
using MediatR;

namespace GestionLivres.MediatorServices.Authors.Requests
{
    public class GetAllAuthorQuery : IRequest<IEnumerable<GetAutorDto>>
    {
    }
}
