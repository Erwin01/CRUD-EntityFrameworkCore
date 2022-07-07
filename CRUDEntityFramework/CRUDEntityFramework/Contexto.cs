using Microsoft.EntityFrameworkCore;

namespace CRUDEntityFramework
{
    public class Contexto : DbContext
    {
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Continente> Continentes { get; set; }
        public DbSet<Presidente> Presidentes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Mundo;Integrated Security=True");
            
        }


    }
}
