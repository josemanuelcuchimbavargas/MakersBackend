using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EditorialsController : ControllerBase
    {
        private readonly WebApiContext _context;

        public EditorialsController(WebApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Editorial>>> GetEditorial()
        {
            return await _context.Editorial.ToListAsync();
        }
        
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Editorial>> GetEditorial(Guid id)
        {
            var editorial = await _context.Editorial.FindAsync(id);

            if (editorial == null)
            {
                return NotFound();
            }

            return editorial;
        }
                
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> PutEditorial(Guid id, Editorial editorial)
        {
            if (id != editorial.IdEditoria)
            {
                return BadRequest();
            }

            _context.Entry(editorial).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EditorialExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            
            return Ok(new { status = true });
        }
       
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Editorial>> PostEditorial(Editorial editorial)
        {
            _context.Editorial.Add(editorial);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEditorial", new { id = editorial.IdEditoria }, editorial);
        }
      
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<ActionResult<Editorial>> DeleteEditorial(Guid id)
        {
            var editorial = await _context.Editorial.FindAsync(id);
            if (editorial == null)
            {
                return NotFound();
            }

            _context.Editorial.Remove(editorial);
            await _context.SaveChangesAsync();

            return editorial;
        }

        private bool EditorialExists(Guid id)
        {
            return _context.Editorial.Any(e => e.IdEditoria == id);
        }
    }
}
