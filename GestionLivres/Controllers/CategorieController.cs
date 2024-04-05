using GestionLivres.DTO.BookDto;
using GestionLivres.DTO.BookDTO;
using GestionLivres.DTO.CategorieDto;
using GestionLivres.DTO.CategorieDTO;
using GestionLivres.Entities;
using GestionLivres.MediatorServices.Categories.AddCategorieCommand;
using GestionLivres.MediatorServices.Categories.GetAllCategorieQuery;
using GestionLivres.MediatorServices.Categories.GetCategorieDetailQuery;
using GestionLivres.Services.Categories;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionLivres.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategorieController : ControllerBase
    {
        private IMediator _mediator;
        public CategorieController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<AddCategorieDto>> AddCategorie(AddCategorieDto request)
        {
            AddCategorieCommand command = new AddCategorieCommand() {dto = request };
           var categorie =await _mediator.Send(command); 
            return Ok(categorie);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetCategorieDto>>> GetListCategorie()
        {
            var list = await _mediator.Send(new GetAllCategorieQuery());
            return Ok(list);

        }

        [HttpGet("detail/id")]
        public async Task<ActionResult<CategorieDetailDto>> GetCategorieDetailById(int id)
        {
            var categorie = await _mediator.Send(new GetCategorieDetailQuery(id));
            return Ok(categorie);

        }


    }
}
