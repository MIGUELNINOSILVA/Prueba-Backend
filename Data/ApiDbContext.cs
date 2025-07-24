using Microsoft.EntityFrameworkCore;

public class ApiDbContext : DbContext
{
    public ApiDbContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Producto> Productos { get; set; }
    public DbSet<ImagenProducto> ImagenesProductos { get; set; }
}
