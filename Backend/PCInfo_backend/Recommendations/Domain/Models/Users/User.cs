﻿namespace PCInfo_backend.Recommendations.Domain.Models.Users;

public class User
{
    public string IDuser { get; set; }
    public string Usuario { get; set; }
    public string Password { get; set; }

    //Relationships
    public IList<Cliente> Clientes { get; set; } = new List<Cliente>();
}