using GestionLivres.DTO.AutorDto;
using GestionLivres.Entities;

namespace GestionLivres.Repository.Autors
{
    public interface IAutorRepository
    {
        public Task<bool> AddAutorRepository(Autor autor);
        public Task <Autor> GetAutorDetailRepository(int id);
        public Task<IEnumerable<Autor>> GetAutorRepository();
        public Task <Autor?>  GetAutorRepositoryById(int id);
    }
}
