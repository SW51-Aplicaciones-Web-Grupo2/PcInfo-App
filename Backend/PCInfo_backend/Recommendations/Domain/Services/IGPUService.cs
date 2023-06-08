using PCInfo_backend.Recommendations.Domain.Models;

namespace PCInfo_backend.Recommendations.Domain.Services;

public interface IGPUService
{
    Task<IEnumerable<GPU>> ListAsync();
    Task<GPU> GetAsync(int id);
    Task<GPU> GetByBrandAndModelAsync(string brand, string model);
    Task<GPU> SaveAsync(GPU gpu);
    Task<GPU> UpdateAsync(int id, GPU gpu);
    Task<GPU> DeleteAsync(int id);
}