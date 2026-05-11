using Microsoft.AspNetCore.Mvc;
using BibliotecaLivro_MVC.Models;
using BibliotecaLivro_MVC.Repository;

namespace BibliotecaLivro_MVC.Controllers
{
    public class LivroController : Controller
    {
        private readonly ILivroRepository _livroRepository;

        public LivroController(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        public IActionResult Index()
        {
            List<Livro> livros = _livroRepository.BuscarTodos();

            return View(livros);
        }

        public IActionResult Create()
        {
            return View();
        }

        
        public IActionResult Create(Livro livro)
        {
            _livroRepository.Adicionar(livro);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Livro livro = _livroRepository.BuscarPorId(id);

            return View(livro);
        }

        
        public IActionResult Edit(Livro livro)
        {
            _livroRepository.Atualizar(livro);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Livro livro = _livroRepository.BuscarPorId(id);

            return View(livro);
        }

        
        public IActionResult DeleteConfirm(int id)
        {
            _livroRepository.Deletar(id);

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Livro livro = _livroRepository.BuscarPorId(id);

            return View(livro);
        }
    }
}