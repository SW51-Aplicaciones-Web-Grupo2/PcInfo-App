namespace PCInfo_backend.Recommendations.Domain.Models.Users;

public class Usuario
{
    public string Id { get; set; }
    public string Nombre { get; set; }
    public string Nusuario { get; set; }
    public string Password { get; set; }
    public string Apellido { get; set; }

    public Usuario(string id, string nombre, string apellido, string password, string nusuario)
    {
        Id = id;
        Nombre = nombre;
        Apellido = apellido;
        Password = password;
        Nusuario = nusuario;
    }
}