namespace PCInfo_backend.Recommendations.Domain.Models;

public class CPU
{
    public string Socket { get; set; }
    public string tipoProcesador { get; set; }
    public int velocidad { get; set; }
    //Relationships
    public int codigoProducto { get; set; }
    public Producto producto { get; set; }
}