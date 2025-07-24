public class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public float Precio { get; set; }
    public string FechaCreacion { get; set; }
    public bool Estado { get; set; }

    public Producto(int id, string nombre, string descripcion, float precio, string fechaCreacion, bool estado)
    {
        Id = id;
        Nombre = nombre;
        Descripcion = descripcion;
        Precio = precio;
        FechaCreacion = fechaCreacion;
        Estado = estado;
    }

}