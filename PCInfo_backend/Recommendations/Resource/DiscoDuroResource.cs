namespace PCInfo_backend.Recommendations.Resource;

public class DiscoDuroResource
{
    public string modelo { get; set; }
    public int capacidad { get; set; }
    public string cache { get; set; }
    public string velocidad { get; set; }
    public string tipo { get; set; }
    public ProductoResource producto { get; set; }
}