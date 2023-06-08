using PCInfo_backend.Recommendations.Domain.Models;

namespace PCInfo_backend.Recommendations.Domain.Repositories;

public interface ICPURepository
{
    Task<IEnumerable<CPU>> ListAsync();
    Task AddAsync(CPU cpu);
    Task<CPU> FindByIdAsync(int id);
    void Update(CPU cpu);
    void Remove(CPU cpu);
}