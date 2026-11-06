using bibliotecaAPI.Domains;
using bibliotecaAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace bibliotecaAPI.Controllers
{
    // controller -> recebe as requisições HTTP e devolve as respostas (json)

    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : Controller
    {
        private readonly LivroService _service;

        public LivroController(LivroService service)
        
            { 
                _service = service;
            }

        [HttpGet] // método GET (para buscar as informações no banco de dados)
        public ActionResult Listar() 
        { 
            List<Livro> livros = _service.Listar();
            return Ok(livros);
        }

        [HttpPost] // endpoint
        public ActionResult Cadastrar(Livro livro)
        {
            try
            {
                Livro novoLivro = _service.Adicionar(livro);

                return Created("Livro criado com sucesso! ", livro);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        
        }

        [HttpPut("{IdLivro}")] // Mudado de "id" para "IdLivro"
        public ActionResult Atualizar(int IdLivro, [FromBody] Livro livro) // Mudado de "id" para "IdLivro"
        {
            try
            {
                // Passa o IdLivro para o seu service normalmente
                bool atualizado = _service.Atualizar(IdLivro, livro);

                if (!atualizado)
                {
                    return NotFound("Livro não foi encontrado");
                }

                return Created("Livro foi atualizado com sucesso", livro);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public ActionResult Deletar(int id)
        {
            try
            {
                bool deletado = _service.Deletar(id);

                if (!deletado)
                {
                    return NotFound("Livro não encontrado!");
                }

                return Created("Livro deletado com sucesso! ", id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}