using PCInfo_backend.Recommendations.Domain.Models.Users;

namespace PCInfo_backend.Recommendations.Domain.Repositories.Users;

public interface IClienteRepository
{
    Task<IEnumerable<Cliente>> ListAsync();
    Task AddAsync(Cliente cliente);
    Task<Cliente> FindByIdAsync(int id);
    void Update(Cliente cliente);
    void Remove(Cliente cliente);
    
}