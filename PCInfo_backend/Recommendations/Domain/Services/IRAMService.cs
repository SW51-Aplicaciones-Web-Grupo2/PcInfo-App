using PCInfo_backend.Recommendations.Domain.Models;

namespace PCInfo_backend.Recommendations.Domain.Services;

public interface IRAMService
{
    Task<IEnumerable<RAM>> ListAsync();
    Task<RAM> GetAsync(int id);
    Task<RAM> SaveAsync(RAM ram);
    Task<RAM> UpdateAsync(int id, RAM ram);
    Task<RAM> DeleteAsync(int id);
    
}