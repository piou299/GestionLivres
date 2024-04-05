using GestionLivres.DTO.AutorDto;
using MediatR;

namespace GestionLivres.MediatorServices.Authors.GetAuthorDetailQuery
{
    public class GetAuthorDetailQuery : IRequest<GetAutorDetailDto>
    {
        public int id;
        public GetAuthorDetailQuery(int id)
        {
            this.id = id;
        }
    }
}
