namespace PCInfo_backend.Recommendations.Domain.Models;

public class Mouse
{
    public string Tasaderepeticion { get; set; }
    public string sensor { get; set; }
    public int DPI { get; set; }
    public string RGB { get; set; }
    public int teclas { get; set; }
    public string tipo { get; set; }
    //Relationships
    public int codigoProducto { get; set; }
    public Producto producto { get; set; }
}