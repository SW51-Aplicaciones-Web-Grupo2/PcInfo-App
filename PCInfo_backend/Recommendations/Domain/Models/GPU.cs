namespace PCInfo_backend.Recommendations.Domain.Models;

public class GPU
{
    public int id { get; set; }
    public string modelo { get; set; }
    public string velocidad { get; set; }
    public string frecuencia { get; set; }
    public int DDR { get; set; }
    public string tipo { get; set; }
    //Relationships
    public int codigoProducto { get; set; }
    public Producto producto { get; set; }
}