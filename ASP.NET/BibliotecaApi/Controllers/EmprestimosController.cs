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
    public class EmprestimosController : ControllerBase
    {
        private readonly BibliotecaDbContext _context;

        public EmprestimosController(BibliotecaDbContext context)
        {
            _context = context;
        }

        // GET: api/Emprestimos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Emprestimos>>> GetEmprestimos()
        {
          if (_context.Emprestimos == null)
          {
              return NotFound();
          }
            return await _context.Emprestimos.ToListAsync();
        }

        // GET: api/Emprestimos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Emprestimos>> GetEmprestimos(int id)
        {
          if (_context.Emprestimos == null)
          {
              return NotFound();
          }
            var emprestimos = await _context.Emprestimos.FindAsync(id);

            if (emprestimos == null)
            {
                return NotFound();
            }

            return emprestimos;
        }

        // PUT: api/Emprestimos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmprestimos(int id, Emprestimos emprestimos)
        {
            if (id != emprestimos.Id)
            {
                return BadRequest();
            }

            _context.Entry(emprestimos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmprestimosExists(id))
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

        // POST: api/Emprestimos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Emprestimos>> PostEmprestimos(Emprestimos emprestimos)
        {
          if (_context.Emprestimos == null)
          {
              return Problem("Entity set 'BibliotecaDbContext.Emprestimos'  is null.");
          }
            _context.Emprestimos.Add(emprestimos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmprestimos", new { id = emprestimos.Id }, emprestimos);
        }

        // DELETE: api/Emprestimos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmprestimos(int id)
        {
            if (_context.Emprestimos == null)
            {
                return NotFound();
            }
            var emprestimos = await _context.Emprestimos.FindAsync(id);
            if (emprestimos == null)
            {
                return NotFound();
            }

            _context.Emprestimos.Remove(emprestimos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmprestimosExists(int id)
        {
            return (_context.Emprestimos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
