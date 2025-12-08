using Microsoft.EntityFrameworkCore;

namespace dbcodefirst
{
    public class AppDbContext : DbContext
    {
        public DbSet<Produto> Produtos {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(Note_Kenzo);Database=EFCoreDB;Trusted_Connection=True; Data Source=Note_Kenzo;" + "Initial Catalog=EFCoreDB;Integrated Security=True;TrustServerCertificate=True;");
        }
    }
}