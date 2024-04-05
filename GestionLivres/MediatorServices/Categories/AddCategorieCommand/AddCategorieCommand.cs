using GestionLivres.DTO.CategorieDTO;
using MediatR;

namespace GestionLivres.MediatorServices.Categories.AddCategorieCommand
{
    public class AddCategorieCommand :IRequest<AddCategorieDto>
    {
        public AddCategorieDto dto { get; set; }
    }
}
