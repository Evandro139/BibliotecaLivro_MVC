using BibliotecaLivro_MVC.Data;
using BibliotecaLivro_MVC.Models;

namespace BibliotecaLivro_MVC.Repository
{
    public class LivroRepository : ILivroRepository
    {
        private readonly AppDbContext _context;

        public LivroRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Livro> BuscarTodos()
        {
            return _context.Livro.ToList();
        }

        public Livro BuscarPorId(int id)
        {
            return _context.Livro.FirstOrDefault(x => x.Id == id);
        }

        public void Adicionar(Livro livro)
        {
            _context.Livro.Add(livro);
            _context.SaveChanges();
        }

        public void Atualizar(Livro livro)
        {
            _context.Livro.Update(livro);
            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            Livro livro = BuscarPorId(id);

            _context.Livro.Remove(livro);
            _context.SaveChanges();
        }
    }
}