using Newtonsoft.Json;

namespace PCInfo_backend.PCInfo.Domain.Models;

public class User
{
    public string idUser { get; set; }
    public string Usuario { get; set; }
    
    [JsonIgnore]
    public string Password { get; set; }
}