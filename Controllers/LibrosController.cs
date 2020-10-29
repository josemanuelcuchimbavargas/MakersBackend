using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibrosController : ControllerBase
    {
        private readonly WebApiContext _context;

        public LibrosController(WebApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<dynamic>>> GetLibro()
        {
      

                var query = from a in _context.Libro
                            join s in _context.Editorial on a.IdEditoria equals s.IdEditoria
                            select new 
                            {
                                Id = a.IdLibro,
                                Titulo = a.Titulo,
                                IdEditoria = a.IdEditoria,
                                Fecha = a.Fecha,
                                Costo = a.Costo,
                                PrecioSugerido = a.PrecioSugerido,
                                Autor = a.Autor,
                                Editorial = s.Nombre

                            };

                return  query.ToList();                       
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Libro>> GetLibro(Guid id)
        {
            var libro = await _context.Libro.FindAsync(id);

            if (libro == null)
            {
                return NotFound();
            }

            return libro;
        }
        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLibro(Guid id, Libro libro)
        {
            if (id != libro.IdLibro)
            {
                return BadRequest();
            }

            _context.Entry(libro).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LibroExists(id))
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
        public async Task<ActionResult<Libro>> PostLibro(Libro libro)
        {
            _context.Libro.Add(libro);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLibro", new { id = libro.IdLibro }, libro);
        }
        
        [HttpDelete("{id}")]
        public async Task<ActionResult<Libro>> DeleteLibro(Guid id)
        {
            var libro = await _context.Libro.FindAsync(id);
            if (libro == null)
            {
                return NotFound();
            }

            _context.Libro.Remove(libro);
            await _context.SaveChangesAsync();

            return libro;
        }

        private bool LibroExists(Guid id)
        {
            return _context.Libro.Any(e => e.IdLibro == id);
        }
    }
}
