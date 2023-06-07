namespace PCInfo_backend.Recommendations.Domain.Models;

public class RAM
{
    public string capacidad { get; set; }
    public string generadorDDR { get; set; }
    public string frecuencia { get; set; }
    public string tipo { get; set; }
    //Relationships
    public int codigoProducto { get; set; }
    public Producto producto { get; set; }
}