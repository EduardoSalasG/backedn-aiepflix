using backedn_aiepflix.DTOs;
using backedn_aiepflix.Entities;
using backedn_aiepflix.Validations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backedn_aiepflix.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RutController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public RutController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpPost("Buscar")]
        public async Task<ActionResult<RUT>> Post(RutDTO rut)
        {

            if (ModelState.IsValid)
            {
                //ValidarRutt(rut);

                var rutDB = await _context.RUT.FirstAsync(x => x.Rut == rut.Rut);
                if (rutDB == null)
                {
                    return BadRequest("El rut no existe");
                }

                rutDB.Rut = rut.Rut;

                return rutDB;

            }
            else
            {
                return BadRequest("La información recibida no es válida");
            }
        }


        [HttpPost]
        public async Task<RutCreacionResponse> Post(RutCreacion rut)
        {

            if (ModelState.IsValid)
            {
                var nuevoRut = new RUT()
                {
                    Rut = rut.Rut,
                    Nombre= rut.Nombre,
                    NombreActividad = rut.NombreActividad,
                    CodigoActividad = rut.CodigoActividad,
                    AfectoIVA = rut.AfectoIVA,
                    FechaInicioAct = rut.FechaInicioAct
                };

                _context.RUT.Add(nuevoRut);
                await _context.SaveChangesAsync();


                //return Ok("RUT ingresado correctamente");
                return new RutCreacionResponse { message="Rut ingresado correctamente"};

            }
            else
            {
                //return BadRequest("La información recibida no es válida");
                return new RutCreacionResponse { message = "La información recibida no es válida" };

            }
        }


    }
}
