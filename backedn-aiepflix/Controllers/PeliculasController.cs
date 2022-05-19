using backedn_aiepflix.DTOs;
using backedn_aiepflix.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backedn_aiepflix.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeliculasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PeliculasController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Pelicula>>> Get()
        {
            var listadoPeliculas = await _context.Peliculas.ToListAsync();
            return listadoPeliculas;
        }


        [HttpPost]
        public async Task<ActionResult> Post(PeliculaCreacion pelicula)
        {

            if(ModelState.IsValid)
            {
                var nuevaPelicula = new Pelicula() 
                {
                    Name = pelicula.Name,
                    Poster = pelicula.Poster,
                    Year = pelicula.Year

                };

                _context.Peliculas.Add(nuevaPelicula);
                await _context.SaveChangesAsync();


                return Ok("Película ingresada correctamente");

            }
            else
            {
                return BadRequest("La información recibida no es válida");
            }
        }

        [HttpPut]
        public async Task<ActionResult> Put(PeliculaDTO pelicula)
        {
          
            if (ModelState.IsValid)
            {
                var peliculaDb = await _context.Peliculas.FirstOrDefaultAsync(x => x.Id == pelicula.Id);
                if (peliculaDb == null)
                {
                    return BadRequest("La película no existe");
                }

                peliculaDb.Name = pelicula.Name;
                peliculaDb.Poster = pelicula.Poster;
                peliculaDb.Year = pelicula.Year;


                _context.Peliculas.Update(peliculaDb);
                await _context.SaveChangesAsync();


                return NoContent();

            }
            else
            {
                return BadRequest("La información recibida no es válida");
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete([FromRoute] int id)
        {
            var peliculaDb = await _context.Peliculas.FirstOrDefaultAsync(x => x.Id == id);
            if (peliculaDb == null)
            {
                return BadRequest("La película no existe");
            }

            _context.Peliculas.Remove(peliculaDb);
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}
