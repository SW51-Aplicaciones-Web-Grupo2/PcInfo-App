using PCInfo_backend.Recommendations.Domain.Models;
using PCInfo_backend.Recommendations.Domain.Services.Communication;

namespace PCInfo_backend.Recommendations.Domain.Services;

public interface IClienteService
{
    Task<IEnumerable<Cliente>> ListAsync();
    Task<ClienteResponse> GetAsync(int id);
    Task<ClienteResponse> SaveAsync(Cliente cliente);
    Task<ClienteResponse> UpdateAsync(int id, Cliente cliente);
    Task<ClienteResponse> DeleteAsync(int id);
}