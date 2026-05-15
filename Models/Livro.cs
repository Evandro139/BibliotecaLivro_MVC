using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaLivro_MVC.Models
{
    public class Livro
    {
        public int Id { get; set; }

        public string? Titulo { get; set; }

        public string? Autor { get; set; }

        public string? Genero { get; set; }

        public int AnoPublicacao { get; set; }

        // public int QuantidadePaginas { get; set; }

        public string? Sinopse { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}