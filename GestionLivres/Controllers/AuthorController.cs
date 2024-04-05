
using GestionLivres.DTO.AutorDto;
using GestionLivres.MediatorServices.Authors.AuthorCommands;
using GestionLivres.MediatorServices.Authors.GetAuthorDetailQuery;
using GestionLivres.MediatorServices.Authors.GetAuthorQueryById;
using GestionLivres.MediatorServices.Authors.Requests;
using GestionLivres.Services.Autors;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionLivres.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private IMediator _mediator;
        public AuthorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost] 
        public async Task<ActionResult<GetAutorDto>> AddAutor(AddAutorDto request)
        {
            var result = await _mediator.Send(new AddAuthorCommand
            {
                dto = request
            });
            return Ok(result);
         
        }


        [HttpGet("id")]
        public async Task<ActionResult<GetAutorByIdDto>> GetAutorById(int id)
        {
            var autor = await _mediator.Send(new GetAuthorQueryById(id));
            return autor != null ? Ok(autor) : NotFound();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetAutorDto>>> GetAutor()
        {
            var result = await _mediator.Send(new GetAllAuthorQuery());
            return Ok(result);
        }

        [HttpGet("detail/id")]
        public async Task<ActionResult<GetAutorDetailDto>> GetAutorDetail(int id)
        {
            var autor = await _mediator.Send(new GetAuthorDetailQuery(id));
            return autor != null ? Ok(autor) : NotFound();

        }


    }
}
