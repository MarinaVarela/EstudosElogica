using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AlunoApi.Data;
using AlunoApi.Models;

namespace AlunoApi.Controllers
{
    [Route("api/alunos")]
    [ApiController]
    public class AlunosController : ControllerBase
    {
        private readonly AlunoDbContext _context;

        public AlunosController(AlunoDbContext context)
        {
            _context = context;
        }

        // GET: /alunos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Alunos>>> GetAlunos()
        {
          if (_context.Alunos == null)
          {
              return NotFound("O recurso solicitado não foi encontrado.");
          }
            return await _context.Alunos.ToListAsync();
        }

        // GET: /alunos/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Alunos>> GetAlunos(int id)
        {
          if (_context.Alunos == null)
          {
              return NotFound("O recurso solicitado não foi encontrado.");
          }
            var alunos = await _context.Alunos.FindAsync(id);

            if (alunos == null)
            {
                return NotFound("O recurso solicitado não foi encontrado.");
            }

            return alunos;
        }

        // PUT: /alunos/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlunos(int id, Alunos alunos)
        {
            if (id != alunos.Id)
            {
                return BadRequest("A solicitação contém dados inválidos ou está ausente de informações necessárias.");
            }

            _context.Entry(alunos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlunosExists(id))
                {
                    return NotFound("O recurso solicitado não foi encontrado.");
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: /alunos
        [HttpPost]
        public async Task<ActionResult<Alunos>> PostAlunos(Alunos alunos)
        {
          if (_context.Alunos == null)
          {
              return BadRequest("A solicitação contém dados inválidos ou está ausente de informações necessárias.");
          }
            _context.Alunos.Add(alunos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAlunos", new { id = alunos.Id }, alunos);
        }

        // DELETE: /alunos/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAlunos(int id)
        {
            if (_context.Alunos == null)
            {
                return NotFound("O recurso solicitado não foi encontrado.");
            }
            var alunos = await _context.Alunos.FindAsync(id);
            if (alunos == null)
            {
                return NotFound("O recurso solicitado não foi encontrado.");
            }

            _context.Alunos.Remove(alunos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AlunosExists(int id)
        {
            return (_context.Alunos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
