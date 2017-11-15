using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiCRUD.Models;

namespace WebApiCRUD.Repository
{
    public class SimuladoRepository
    {
        private static List<Livro> livros;

        public static List<Livro> Livros
        {
            get
            {
                if (livros == null)
                    GerarLivros();
                return livros;
            }
            set
            {
                livros = value;
            }
        }

        private static void GerarLivros()
        {
            livros = new List<Livro>();

            livros.Add(new Livro
            {
                Id = 1,
                Titulo = "Agile",
                Autor = "André Faria Gomes"
            });

            livros.Add(new Livro
            {
                Id = 2,
                Titulo = "Building Microservices",
                Autor = "Sam Newman"
            });

            livros.Add(new Livro
            {
                Id = 3,
                Titulo = "Controlando versões com Git e Github",
                Autor = "Alexandre Aquiles; Rodrigo Ferreira"
            });
        }
    }
}