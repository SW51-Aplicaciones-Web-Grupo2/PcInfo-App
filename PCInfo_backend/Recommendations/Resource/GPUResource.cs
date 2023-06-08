namespace PCInfo_backend.Recommendations.Resource;

public class GPUResource
{
    public int id { get; set; }
    public string modelo { get; set; }
    public string velocidad { get; set; }
    public string frecuencia { get; set; }
    public int DDR { get; set; }
    public string tipo { get; set; }
    public ProductoResource producto { get; set; }
}