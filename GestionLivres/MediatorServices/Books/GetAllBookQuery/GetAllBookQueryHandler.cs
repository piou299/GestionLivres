using AutoMapper;
using GestionLivres.DTO.AutorDto;
using GestionLivres.DTO.BookDTO;
using GestionLivres.MediatorServices.Authors.Requests;
using GestionLivres.Repository.Autors;
using GestionLivres.Repository.Books;
using MediatR;

namespace GestionLivres.MediatorServices.Books.GetAllBookQuery
{
    public class GetAllBookQueryHandler : IRequestHandler<GetAllBookQuery, IEnumerable<GetBookDto>>
    {
        private readonly IBookRepository _repository;
        private readonly IMapper _mapper;
        public GetAllBookQueryHandler(IBookRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<GetBookDto>> Handle(GetAllBookQuery request, CancellationToken cancellationToken)
        {
            var listbook = _repository.GetAllBokk();
            var result = _mapper.Map<IEnumerable<GetBookDto>>(listbook);
            return result;
        }
    }
}
