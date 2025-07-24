using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class ImagenProductosController : ControllerBase
{
    private readonly ApiDbContext _context;

    public ImagenProductosController(ApiDbContext context)
    {
        _context = context;
    }

    //Get todos los productos
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ImagenProducto>>> GetImagenProductos()
    {
        return await _context.ImagenesProductos.ToListAsync();
    }


    //Get un producto
    [HttpGet("{id}")]
    public async Task<ActionResult<ImagenProducto>> GetImagenProductoById(int id)
    {
        var producto = await _context.ImagenesProductos.FindAsync(id);
        if (producto == null)
        {
            return NotFound();
        }
        return producto;
    }

    //Post producto
    [HttpPost]
    public async Task<ActionResult<ImagenProducto>> PostImagenProducto(ImagenProducto producto)
    {
        _context.ImagenesProductos.Add(producto);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(ImagenProducto), producto);
    }

    //PUT producto
    [HttpPut("{id}")]
    public async Task<IActionResult> PutImagenProducto(int id, ImagenProducto producto)
    {
        if (id != producto.Id)
        {
            return BadRequest();
        }
        _context.Entry(producto).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.ImagenesProductos.Any(p => p.Id == id))
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

    //Delete producto
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteImagenProducto(int id)
    {
        var producto = await _context.ImagenesProductos.FindAsync(id);
        if (producto == null)
        {
            return NotFound();
        }
        _context.ImagenesProductos.Remove(producto);
        await _context.SaveChangesAsync();
        return NoContent();
    }


}