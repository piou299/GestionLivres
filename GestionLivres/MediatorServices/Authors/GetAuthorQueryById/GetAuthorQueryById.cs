using GestionLivres.DTO.AutorDto;
using MediatR;

namespace GestionLivres.MediatorServices.Authors.GetAuthorQueryById
{
    public class GetAuthorQueryById : IRequest<GetAutorByIdDto>
    {
        public int id;

        public GetAuthorQueryById(int id)
        {
            this.id = id;
        }
    }
}
