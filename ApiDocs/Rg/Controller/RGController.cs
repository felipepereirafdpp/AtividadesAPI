using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AtividadesAPI.ApiDocs.Data;
using AtividadesAPI.ApiDocs.Rg.Model;

namespace AtividadesAPI.ApiDocs.Rg.Controller;

[Route("api/[controller]")]
[ApiController]
public class RGController : ControllerBase
{
    private readonly DocumentosContext _context;

    public RGController(DocumentosContext context)
    {
        _context = context;
    }

    // GET: api/RG
    [HttpGet]
    public async Task<ActionResult<IEnumerable<RgModel>>> GetRgModel()
    {
        return await _context.Rgs.ToListAsync();
    }

    // GET: api/RG/5
    [HttpGet("{id}")]
    public async Task<ActionResult<RgModel>> GetRgModel(Guid id)
    {
        var rgModel = await _context.Rgs.FindAsync(id); //Find Asnyc ele serve para procurar pelo id do ()

        if (rgModel == null)
        {
            return NotFound();
        }

        return rgModel;
    }

    // PUT: api/RG/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutRgModel(Guid id, RgModel rgModel)
    {
        if (id != rgModel.Id)
        {
            return BadRequest();
        }

        _context.Entry(rgModel).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!RgModelExists(id))
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

    // POST: api/RG
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<RgModel>> PostRgModel(RgModel rgModel)
    {
        _context.Rgs.Add(rgModel);
        await _context.SaveChangesAsync();

        return StatusCode(201,rgModel);
    }

    // DELETE: api/RG/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteRgModel(Guid id)
    {
        var rgModel = await _context.Rgs.FindAsync(id);
        if (rgModel == null)
        {
            return NotFound();
        }

        _context.Rgs.Remove(rgModel);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool RgModelExists(Guid id)
    {
        return _context.Rgs.Any(e => e.Id == id);
    }
}
