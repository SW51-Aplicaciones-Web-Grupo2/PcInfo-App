namespace PCInfo_backend.Recommendations.Resource;

public class CPUResource
{
    public int id { get; set; }
    public string Socket { get; set; }
    public string tipoProcesador { get; set; }
    public int velocidad { get; set; }
    public ProductoResource producto { get; set; }
}