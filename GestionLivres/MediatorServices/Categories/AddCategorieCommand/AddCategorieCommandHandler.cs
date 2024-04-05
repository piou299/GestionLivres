using AutoMapper;
using GestionLivres.DTO.AutorDto;
using GestionLivres.DTO.BookDTO;
using GestionLivres.DTO.CategorieDTO;
using GestionLivres.Entities;
using GestionLivres.MediatorServices.Authors.AuthorCommands;
using GestionLivres.Repository.Books;
using GestionLivres.Repository.Categories;
using MediatR;

namespace GestionLivres.MediatorServices.Categories.AddCategorieCommand
{
    public class AddCategorieCommandHandler : IRequestHandler<AddCategorieCommand, AddCategorieDto>
    {
        private readonly ICategorieRepository _repository;
        private readonly IMapper _mapper;
        public AddCategorieCommandHandler(ICategorieRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<AddCategorieDto> Handle(AddCategorieCommand request, CancellationToken cancellationToken)
        {
            var categorie = _mapper.Map<Categorie>(request.dto);
            _repository.AddNewCategorie(categorie);

            var getCategorieDto =  _mapper.Map<AddCategorieDto>(categorie);
            return getCategorieDto;
        }
    }
}
