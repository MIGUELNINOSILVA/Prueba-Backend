using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class ProductosController : ControllerBase
{
    private readonly ApiDbContext _context;

    public ProductosController(ApiDbContext context)
    {
        _context = context;
    }

    //Get todos los productos
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Producto>>> GetProductos()
    {
        return await _context.Productos.ToListAsync();
    }


    //Get un producto
    [HttpGet("{id}")]
    public async Task<ActionResult<Producto>> GetProductoById(int id)
    {
        var producto = await _context.Productos.FindAsync(id);
        if (producto == null)
        {
            return NotFound();
        }
        return producto;
    }

    //Post producto
    [HttpPost]
    public async Task<ActionResult<Producto>> PostProducto([FromBody] Producto producto)
    {
        _context.Productos.Add(producto);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetProductoById), new { id = producto.Id }, producto);
    }

    //PUT producto
    [HttpPut("{id}")]
    public async Task<IActionResult> PutProducto(int id, [FromBody] Producto producto)
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
            if (!_context.Productos.Any(p => p.Id == id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return Ok(producto);
    }

    //Delete producto
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProducto(int id)
    {
        var producto = await _context.Productos.FindAsync(id);
        if (producto == null)
        {
            return NotFound();
        }
        _context.Productos.Remove(producto);
        await _context.SaveChangesAsync();
        return NoContent();
    }


}