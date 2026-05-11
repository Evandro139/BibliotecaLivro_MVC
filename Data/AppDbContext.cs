using Microsoft.EntityFrameworkCore;
using BibliotecaLivro_MVC.Models;

namespace BibliotecaLivro_MVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Livro> Livro { get; set; }
    }
}