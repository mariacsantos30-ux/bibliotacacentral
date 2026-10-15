using Microsoft.EntityFrameworkCore;
using bibliotecacentral.Models;

namespace bibliotecacentral.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        
        public DbSet<Livro> Livros { get; set; }
    }
}
