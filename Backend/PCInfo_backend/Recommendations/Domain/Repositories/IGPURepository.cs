using PCInfo_backend.Recommendations.Domain.Models;

namespace PCInfo_backend.Recommendations.Domain.Repositories;

public interface IGPURepository
{
    Task<IEnumerable<GPU>> ListAsync();
    Task AddAsync(GPU gpu);
    Task<GPU> FindByIdAsync(int id);
    void Update(GPU gpu);
    void Remove(GPU gpu);
}