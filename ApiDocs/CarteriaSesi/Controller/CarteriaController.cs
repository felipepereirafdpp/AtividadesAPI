using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AtividadesAPI.ApiDocs.CarteriaSesi.Model;
using AtividadesAPI.ApiDocs.Data;

namespace AtividadesAPI.ApiDocs.CarteriaSesi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarteriaController : ControllerBase
    {
        private readonly DocumentosContext _context;

        public CarteriaController(DocumentosContext context)
        {
            _context = context;
        }

        // GET: api/Carteria
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarteriaModel>>> GetCarteriaModel()
        {
            return await _context.Carterinhas.ToListAsync();
        }

        // GET: api/Carteria/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CarteriaModel>> GetCarteriaModel(Guid id)
        {
            var carteriaModel = await _context.Carterinhas.FindAsync(id);

            if (carteriaModel == null)
            {
                return NotFound();
            }

            return carteriaModel;
        }

        // PUT: api/Carteria/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarteriaModel(Guid id, CarteriaModel carteriaModel)
        {
            if (id != carteriaModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(carteriaModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarteriaModelExists(id))
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

        // POST: api/Carteria
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CarteriaModel>> PostCarteriaModel(CarteriaModel carteriaModel)
        {
            _context.Carterinhas.Add(carteriaModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCarteriaModel", new { id = carteriaModel.Id }, carteriaModel);
        }

        // DELETE: api/Carteria/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarteriaModel(Guid id)
        {
            var carteriaModel = await _context.Carterinhas.FindAsync(id);
            if (carteriaModel == null)
            {
                return NotFound();
            }

            _context.Carterinhas.Remove(carteriaModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CarteriaModelExists(Guid id)
        {
            return _context.Carterinhas.Any(e => e.Id == id);
        }
    }
}
