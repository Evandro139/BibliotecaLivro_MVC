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

        // ======================
        // LISTA
        // ======================
        public IActionResult Index()
        {
            var livros = _livroRepository.BuscarTodos();
            return View(livros);
        }
        
        // GET
        public IActionResult Create()
        {
            return View();
        }

        // POST
        [HttpPost]
        public IActionResult Create(Livro livro)
        {
            if (!ModelState.IsValid)
                return View(livro);

            livro.DataCadastro = DateTime.Now;

            _livroRepository.Adicionar(livro);

            return RedirectToAction(nameof(Index));
        }

     
        // GET
        public IActionResult Delete()
        {
            return View();
        }

        // POST
        [HttpPost]
        public IActionResult Delete(int id)
        {
            _livroRepository.Deletar(id);

            return RedirectToAction(nameof(Index));
        }

      

        // GET
        public IActionResult Edit()
        {
            return View();
        }

        // POST
        [HttpPost]
        public IActionResult Edit(int id, string titulo, string autor, string genero, int anoPublicacao)
        {
            var livro = _livroRepository.BuscarPorId(id);

            if (livro == null)
                return RedirectToAction(nameof(Index));

            livro.Titulo = titulo;
            livro.Autor = autor;
            livro.Genero = genero;
            livro.AnoPublicacao = anoPublicacao;

            _livroRepository.Atualizar(livro);

            return RedirectToAction(nameof(Index));
        }
    }
}