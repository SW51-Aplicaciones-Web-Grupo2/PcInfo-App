using PCInfo_backend.Recommendations.Domain.Models;

namespace PCInfo_backend.Recommendations.Domain.Repositories;

public interface IRAMRepository
{
    Task<IEnumerable<RAM>> ListAsync();
    Task AddAsync(RAM ram);
    Task<RAM> FindByIdAsync(int id);
    void Update(RAM ram);
    void Remove(RAM ram);
}