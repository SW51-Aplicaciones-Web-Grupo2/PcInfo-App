namespace PCInfo_backend.Recommendations.Resource;

public class MonitorResource
{
    public string resolucion { get; set; }
    public int pulgadas { get; set; }
    public string HDR { get; set; }
    public string conexiones { get; set; }
    public ProductoResource producto { get; set; }
}