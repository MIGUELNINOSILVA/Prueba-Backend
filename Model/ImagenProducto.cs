public class ImagenProducto
{
    public int Id { get; set; }
    public string ImagenPath { get; set; }

    public ImagenProducto(int id, string imagenPath)
    {
        Id = id;
        ImagenPath = imagenPath;
    }
}