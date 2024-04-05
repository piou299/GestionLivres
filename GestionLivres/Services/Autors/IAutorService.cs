using GestionLivres.DTO.AutorDto;
using GestionLivres.Entities;

namespace GestionLivres.Services.Autors
{
    public interface IAutorService
    {
        public bool AddAutorService(AddAutorDto request);
        public GetAutorDetailDto GetAutorDetailService(int Id);
        public IEnumerable<GetAutorDto> GetAutorService();
        public GetAutorByIdDto GetAutorServiceById(int Id);
    }
}
