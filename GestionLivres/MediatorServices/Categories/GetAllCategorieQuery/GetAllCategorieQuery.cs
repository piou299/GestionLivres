using GestionLivres.DTO.AutorDto;
using GestionLivres.DTO.CategorieDto;
using MediatR;

namespace GestionLivres.MediatorServices.Categories.GetAllCategorieQuery
{
    public class GetAllCategorieQuery : IRequest<IEnumerable<GetCategorieDto>>
    {
    }
}
