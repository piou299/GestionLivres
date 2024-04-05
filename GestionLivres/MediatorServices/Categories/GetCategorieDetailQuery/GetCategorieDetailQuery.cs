using GestionLivres.DTO.CategorieDTO;
using MediatR;

namespace GestionLivres.MediatorServices.Categories.GetCategorieDetailQuery
{
    public class GetCategorieDetailQuery: IRequest<CategorieDetailDto>
    {
        public int id;
        public GetCategorieDetailQuery(int id) { this.id = id; }
    }
}
