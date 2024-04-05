using AutoMapper;
using GestionLivres.DTO.AutorDto;
using GestionLivres.DTO.BookDto;
using GestionLivres.DTO.BookDTO;
using GestionLivres.Entities;
using GestionLivres.Repository.Books;
using MediatR;

namespace GestionLivres.MediatorServices.Books.GetBookQueryById
{
    public class GetBookQueryByIdHandler : IRequestHandler<GetBookQueryById, GetBookByIdDto>
    {
        private readonly IBookRepository _repository;
        private readonly IMapper _mapper;
        public GetBookQueryByIdHandler(IBookRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<GetBookByIdDto> Handle(GetBookQueryById request, CancellationToken cancellationToken)
        {
            var book = _repository.GetFirtBookById(request.id);
            var result = _mapper.Map<GetBookByIdDto>(book);
            return result;
        }
    }
}
