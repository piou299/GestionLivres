using GestionLivres.Entities;
using Microsoft.EntityFrameworkCore;

namespace GestionLivres.Datas
{
    public class ApplicationsContext:DbContext
    {
        public ApplicationsContext(DbContextOptions<ApplicationsContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Autor> Autors { get; set; }
        public DbSet<Categorie> Categories { get; set; }
    }
}
