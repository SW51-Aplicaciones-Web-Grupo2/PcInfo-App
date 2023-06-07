namespace PCInfo_backend.Recommendations.Domain.Models;

public class DiscoDuro
{
    public int id { get; set; }
    public string modelo { get; set; }
    public int capacidad { get; set; }
    public string cache { get; set; }
    public string velocidad { get; set; }
    public string tipo { get; set; }
    //Relationships
    public int codigoProducto { get; set; }
    public Producto producto { get; set; }
}