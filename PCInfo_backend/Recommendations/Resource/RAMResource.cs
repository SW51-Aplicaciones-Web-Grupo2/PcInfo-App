namespace PCInfo_backend.Recommendations.Resource;

public class RAMResource
{
    public string capacidad { get; set; }
    public string generadorDDR { get; set; }
    public string frecuencia { get; set; }
    public string tipo { get; set; }
    public ProductoResource producto { get; set; }
}