using GestionLivres.Datas;
using GestionLivres.Entities;
using Microsoft.EntityFrameworkCore;

namespace GestionLivres.Repository.Categories
{
    public class CategorieRepository : ICategorieRepository
    {
        private readonly ApplicationsContext _Context;
        public CategorieRepository(ApplicationsContext Context)
        {
            _Context = Context;
        }
        public Categorie AddNewCategorie(Categorie request)
        {
          _Context.Categories.Add(request);
           _Context.SaveChanges();
            return request;
        }

        public IEnumerable<Categorie> GetAllCategorie() => _Context.Categories;

        public Categorie GetFirtCategorieById(int Id)
        {
            //return _Context.Categories.SingleOrDefault(b => b.CategorieId == Id);

            var result = _Context.Categories
              .Include(b => b.Books)
              .SingleOrDefault(b => b.CategorieId == Id);
            return result;
        }

    }
}
