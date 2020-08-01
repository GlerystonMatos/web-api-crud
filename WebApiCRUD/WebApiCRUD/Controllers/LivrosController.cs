using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiCRUD.Models;
using WebApiCRUD.Repository;

namespace WebApiCRUD.Controllers
{
    public class LivrosController : ApiController
    {
        // GET: api/Livros
        public IEnumerable<Livro> Get()
        {
            return SimuladoRepository.Livros;
        }

        // GET: api/Livros/5
        public IHttpActionResult Get(int id)
        {
            Livro livro = SimuladoRepository.Livros.FirstOrDefault(l => l.Id == id);

            if (livro != null)
                return ResponseMessage(Request.CreateResponse<Livro>(HttpStatusCode.OK, livro));
            else
                return ResponseMessage(Request.CreateResponse<string>(HttpStatusCode.NotFound, "Livro não localizado."));
        }

        // POST: api/Livros
        public IHttpActionResult Post([FromBody]Livro objeto)
        {
            Livro livro = SimuladoRepository.Livros.FirstOrDefault(l => l.Id == objeto.Id);

            if (livro != null)
                return ResponseMessage(Request.CreateResponse<string>(HttpStatusCode.Conflict, "Já existe um livro cadastrado com esse ID."));
            else
            {
                SimuladoRepository.Livros.Add(objeto);
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK));
            }
        }

        // PUT: api/Livros/5
        public IHttpActionResult Put([FromBody]Livro objeto)
        {
            Livro livro = SimuladoRepository.Livros.FirstOrDefault(l => l.Id == objeto.Id);

            if (livro != null)
            {
                livro.Autor = objeto.Autor;
                livro.Titulo = objeto.Titulo;
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK));
            }
            else
                return ResponseMessage(Request.CreateResponse<string>(HttpStatusCode.NotFound, "Livro não localizado para alteração."));
        }

        // DELETE: api/Livros/5
        public IHttpActionResult Delete(int id)
        {
            Livro livro = SimuladoRepository.Livros.FirstOrDefault(l => l.Id == id);

            if (livro != null)
            {
                SimuladoRepository.Livros.Remove(livro);
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK));
            }
            else
                return ResponseMessage(Request.CreateResponse<string>(HttpStatusCode.NotFound, "Livro não localizado para exclusão."));
        }
    }
}
