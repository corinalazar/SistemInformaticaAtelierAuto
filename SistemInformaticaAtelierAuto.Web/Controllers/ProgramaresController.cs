using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemInformaticaAtelierAuto.Web.Data;
using SistemInformaticaAtelierAuto.Web.Models;

namespace SistemInformaticaAtelierAuto.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgramaresController : ControllerBase
    {
        private readonly SistemInformaticaAtelierAutoWebContext _context;

        public ProgramaresController(SistemInformaticaAtelierAutoWebContext context)
        {
            _context = context;
        }

        // GET: api/Programares
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Programare>>> GetProgramari()
        {
            return await _context.Programari.ToListAsync();
        }

        // GET: api/Programares/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Programare>> GetProgramare(int id)
        {
            var programare = await _context.Programari.FindAsync(id);

            if (programare == null)
            {
                return NotFound();
            }

            return programare;
        }

        // PUT: api/Programares/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProgramare(int id, Programare programare)
        {
            if (id != programare.Id)
            {
                return BadRequest();
            }

            _context.Entry(programare).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProgramareExists(id))
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

        // POST: api/Programares
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Programare>> PostProgramare(Programare programare)
        {
            _context.Programari.Add(programare);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProgramare", new { id = programare.Id }, programare);
        }

        // DELETE: api/Programares/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProgramare(int id)
        {
            var programare = await _context.Programari.FindAsync(id);
            if (programare == null)
            {
                return NotFound();
            }

            _context.Programari.Remove(programare);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProgramareExists(int id)
        {
            return _context.Programari.Any(e => e.Id == id);
        }
    }
}
