using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using bibliotecacentral.Models;
using bibliotecacentral.Data;
using Microsoft.EntityFrameworkCore;

namespace bibliotacacentral.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public LivrosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
      public async Task<ActionResult<IEnumerable<Livro>>>
            GetLivros()
      {
            return await _context.Livros.ToListAsync();
      }

        [HttpPost]
        public async Task<IActionResult> CadastrarLivro(Livro livro)
        {
            _context.Livros.Add(livro);
            await _context.SaveChangesAsync();

            return Ok("Livro cadastrado ccoom sucesso!");
        }

           
    }
}
