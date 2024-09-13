using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiBrawlstars.Data;
using ApiBrawlstars.Models;

namespace ApiBrawlstars.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrawlstarsController : ControllerBase
    {
        private readonly DbBsContext _context;

        public BrawlstarsController(DbBsContext context)
        {
            _context = context;
        }

        // GET: api/Brawlstars
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Brawlstar>>> GetBrawlstar()
        {
          if (_context.Brawlstar == null)
          {
              return NotFound();
          }
            return await _context.Brawlstar.ToListAsync();
        }

        // GET: api/Brawlstars/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Brawlstar>> GetBrawlstar(int id)
        {
          if (_context.Brawlstar == null)
          {
              return NotFound();
          }
            var brawlstar = await _context.Brawlstar.FindAsync(id);

            if (brawlstar == null)
            {
                return NotFound();
            }

            return brawlstar;
        }

        // PUT: api/Brawlstars/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBrawlstar(int id, Brawlstar brawlstar)
        {
            if (id != brawlstar.Id)
            {
                return BadRequest();
            }

            _context.Entry(brawlstar).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BrawlstarExists(id))
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

        // POST: api/Brawlstars
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Brawlstar>> PostBrawlstar(Brawlstar brawlstar)
        {
          if (_context.Brawlstar == null)
          {
              return Problem("Entity set 'DbBsContext.Brawlstar'  is null.");
          }
            _context.Brawlstar.Add(brawlstar);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBrawlstar", new { id = brawlstar.Id }, brawlstar);
        }

        // DELETE: api/Brawlstars/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBrawlstar(int id)
        {
            if (_context.Brawlstar == null)
            {
                return NotFound();
            }
            var brawlstar = await _context.Brawlstar.FindAsync(id);
            if (brawlstar == null)
            {
                return NotFound();
            }

            _context.Brawlstar.Remove(brawlstar);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BrawlstarExists(int id)
        {
            return (_context.Brawlstar?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
