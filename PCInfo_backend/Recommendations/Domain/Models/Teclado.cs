namespace PCInfo_backend.Recommendations.Domain.Models;

public class Teclado
{
    public string tipo { get; set; }
    public string RGB { get; set; }
    public int teclas { get; set; }
    public string modelo { get; set; }
    public string distribucion { get; set; }
    
    //Relationships
    public int codigoProducto { get; set; }
    public Producto producto { get; set; }
}