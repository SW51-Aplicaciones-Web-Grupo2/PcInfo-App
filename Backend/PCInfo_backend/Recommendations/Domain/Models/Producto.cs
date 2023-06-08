namespace PCInfo_backend.Recommendations.Domain.Models;

public class Producto
{
    public int Codigo { get; set; }
    public string Nombre { get; set; }
    public string Marca { get; set; }
    public double Precio { get; set; }
    public string Descripcion { get; set; }
    public int Stock { get; set; }
    
    //Relationships
    public IList<CPU> Cpus { get; set; } = new List<CPU>();
    public IList<GPU> Gpus { get; set; } = new List<GPU>();
    public IList<Monitor> Monitores { get; set; } = new List<Monitor>();
    public IList<RAM> Rams { get; set; } = new List<RAM>();
    public IList<Mouse> Mouses { get; set; } = new List<Mouse>();
    public IList<DiscoDuro> DiscoDuros { get; set; } = new List<DiscoDuro>();
    public IList<Teclado> Teclados { get; set; } = new List<Teclado>();
}