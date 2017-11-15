using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiCRUD.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
    }
}