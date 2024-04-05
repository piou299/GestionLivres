using GestionLivres.DTO.AutorDto;
using MediatR;

namespace GestionLivres.MediatorServices.Authors.AuthorCommands
{
    public class AddAuthorCommand : IRequest<GetAutorDto>
    {
        public AddAutorDto dto { get; set; }
    }
}
