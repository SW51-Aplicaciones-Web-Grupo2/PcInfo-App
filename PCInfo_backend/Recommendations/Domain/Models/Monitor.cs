namespace PCInfo_backend.Recommendations.Domain.Models;

public class Monitor
{
    public string resolucion { get; set; }
    public int pulgadas { get; set; }
    public string HDR { get; set; }
    public string conexiones { get; set; }
    //Relationships
    public int codigoProducto { get; set; }
    public Producto producto { get; set; }
}