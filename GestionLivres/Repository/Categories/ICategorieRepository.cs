using GestionLivres.Entities;
using System.Xml.Linq;

namespace GestionLivres.Repository.Categories
{
    public interface ICategorieRepository
    {
        public Categorie AddNewCategorie(Categorie request);
        public IEnumerable<Categorie> GetAllCategorie();
        public Categorie GetFirtCategorieById(int Id);
    }
}
