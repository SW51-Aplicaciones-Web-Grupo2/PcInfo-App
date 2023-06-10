using PCInfo_backend.Recommendations.Domain.Models.Users;

namespace PCInfo_backend.Recommendations.Domain.Services;

public interface IClienteService
{
    Task<IEnumerable<Cliente>> ListAsync();
    Task<Cliente> GetAsync(int id);
    Task<Cliente> SaveAsync(Cliente cliente);
    Task<Cliente> UpdateAsync(int id, Cliente cliente);
    Task<Cliente> DeleteAsync(int id);
}