using Microsoft.EntityFrameworkCore;
using BibliotecaLivro_MVC.Models;

namespace BibliotecaLivro_MVC.Context
{
    public class LivroDBContext : DbContext
    {
        public LivroDBContext(DbContextOptions<LivroDBContext> options)
            : base(options)
        {
        }

        public DbSet<Livro> Livros { get; set; }
    }
}