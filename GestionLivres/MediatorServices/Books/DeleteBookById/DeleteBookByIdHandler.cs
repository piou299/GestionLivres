using AutoMapper;
using GestionLivres.DTO.BookDto;
using GestionLivres.DTO.BookDTO;
using GestionLivres.Repository.Books;
using MediatR;

namespace GestionLivres.MediatorServices.Books.DeleteBookById
{
    public class DeleteBookByIdHandler : IRequestHandler<DeleteBookById, DeleteBookDto>
    {
        private readonly IBookRepository _repository;
        private readonly IMapper _mapper;
        public DeleteBookByIdHandler(IBookRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<DeleteBookDto> Handle(DeleteBookById request, CancellationToken cancellationToken)
        {
            var book = _repository.DeleteBookrepository(request.id);
            var getBookDeleteDto =  _mapper.Map<DeleteBookDto>(book);
            return getBookDeleteDto;
        }
    }
}
