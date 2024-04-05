using AutoMapper;
using GestionLivres.DTO.AutorDto;
using GestionLivres.DTO.BookDTO;
using GestionLivres.Entities;
using GestionLivres.MediatorServices.Authors.AuthorCommands;
using GestionLivres.Repository.Autors;
using GestionLivres.Repository.Books;
using MediatR;

namespace GestionLivres.MediatorServices.Books.AddBookCommand
{
    public class AddBookCommandHandler : IRequestHandler<AddBookCommand, GetBookDto>
    {
        private readonly IBookRepository _repository;
        private readonly IMapper _mapper;
        public AddBookCommandHandler(IBookRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<GetBookDto> Handle(AddBookCommand request, CancellationToken cancellationToken)
        {
            var book = _mapper.Map<Book>(request.dto);
            _repository.AddNewBook(book);

            var getBookDto = _mapper.Map<GetBookDto>(book);
            return getBookDto;
        }
    }
}
