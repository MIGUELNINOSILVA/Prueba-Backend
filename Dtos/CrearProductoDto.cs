using System.ComponentModel.DataAnnotations;

public class CrearProducto
{
    [Required]
    public int Id { get; set; }
    [Required]
    public string Nombre { get; set; }
    [Required]
    public float Precio { get; set; }
    [Required]
    public string Descripcion { get; set; }
    [Required]
    public bool Estado { get; set; }
}