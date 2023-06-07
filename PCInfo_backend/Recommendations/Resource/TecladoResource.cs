namespace PCInfo_backend.Recommendations.Resource;

public class TecladoResource
{
    public string tipo { get; set; }
    public string RGB { get; set; }
    public int teclas { get; set; }
    public string modelo { get; set; }
    public string distribucion { get; set; }
    public ProductoResource producto { get; set; }
}