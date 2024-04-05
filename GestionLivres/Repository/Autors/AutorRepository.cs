using GestionLivres.Datas;
using GestionLivres.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace GestionLivres.Repository.Autors
{
    public class AutorRepository : IAutorRepository
    {
        private readonly ApplicationsContext _context;
        public AutorRepository(ApplicationsContext context)
        {
            _context = context;
        }
        public async Task <bool> AddAutorRepository(Autor autor)
        {
           await _context.Autors.AddAsync(autor);
           await _context.SaveChangesAsync();
            return true;
        }

        public async Task <Autor> GetAutorDetailRepository(int id)
        {
            var result = await GetAutorRepositoryById(id);
            return result;
        }

        public async Task<IEnumerable<Autor>> GetAutorRepository()
        {
            return await _context.Autors.ToListAsync();
        } 

        public async Task <Autor?> GetAutorRepositoryById(int id)
        {
            var result = await _context.Autors.Include(b => b.Books).SingleOrDefaultAsync(a => a.AutorId == id);
            return result ;
        }
    }
}
