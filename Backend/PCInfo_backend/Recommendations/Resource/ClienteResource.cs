using PCInfo_backend.Recommendations.Domain.Models.Users;

namespace PCInfo_backend.Recommendations.Resource;

public class ClienteResource
{
    public string DNI { get; set; }
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public string Telefono { get; set; }
    public string Correo { get; set; }
    public string Direccion { get; set; }
    public User user { get; set; }
}