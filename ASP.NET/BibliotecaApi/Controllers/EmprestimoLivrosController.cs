using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BibliotecaApi.Data;
using BibliotecaApi.Models;

namespace BibliotecaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmprestimoLivrosController : ControllerBase
    {
        private readonly BibliotecaDbContext _context;

        public EmprestimoLivrosController(BibliotecaDbContext context)
        {
            _context = context;
        }

        // GET: api/EmprestimoLivroes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmprestimoLivro>>> GetEmprestimoLivro()
        {
          if (_context.EmprestimoLivro == null)
          {
              return NotFound();
          }
            return await _context.EmprestimoLivro.ToListAsync();
        }

        // GET: api/EmprestimoLivroes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmprestimoLivro>> GetEmprestimoLivro(int id)
        {
          if (_context.EmprestimoLivro == null)
          {
              return NotFound();
          }
            var emprestimoLivro = await _context.EmprestimoLivro.FindAsync(id);

            if (emprestimoLivro == null)
            {
                return NotFound();
            }

            return emprestimoLivro;
        }

        // PUT: api/EmprestimoLivroes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmprestimoLivro(int id, EmprestimoLivro emprestimoLivro)
        {
            if (id != emprestimoLivro.Id)
            {
                return BadRequest();
            }

            _context.Entry(emprestimoLivro).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmprestimoLivroExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/EmprestimoLivroes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EmprestimoLivro>> PostEmprestimoLivro(EmprestimoLivro emprestimoLivro)
        {
          if (_context.EmprestimoLivro == null)
          {
              return Problem("Entity set 'BibliotecaDbContext.EmprestimoLivro'  is null.");
          }
            _context.EmprestimoLivro.Add(emprestimoLivro);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmprestimoLivro", new { id = emprestimoLivro.Id }, emprestimoLivro);
        }

        // DELETE: api/EmprestimoLivroes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmprestimoLivro(int id)
        {
            if (_context.EmprestimoLivro == null)
            {
                return NotFound();
            }
            var emprestimoLivro = await _context.EmprestimoLivro.FindAsync(id);
            if (emprestimoLivro == null)
            {
                return NotFound();
            }

            _context.EmprestimoLivro.Remove(emprestimoLivro);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmprestimoLivroExists(int id)
        {
            return (_context.EmprestimoLivro?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
