 using BibliotecaLivro_MVC.Models;

namespace BibliotecaLivro_MVC.Repository
{
    public interface ILivroRepository
    {
        List<Livro> BuscarTodos();

        Livro BuscarPorId(int id);

        void Adicionar(Livro livro);

        void Atualizar(Livro livro);

        void Deletar(int id);
    }
}