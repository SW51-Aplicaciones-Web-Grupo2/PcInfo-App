using Monitor = PCInfo_backend.Recommendations.Domain.Models.Monitor;

namespace PCInfo_backend.Recommendations.Domain.Services;

public interface IMonitorService
{
    Task<IEnumerable<Monitor>> ListAsync();
    Task<Monitor> GetAsync(int id);
    Task<Monitor> GetByBrandAndModelAsync(string brand, string model);
    Task<Monitor> SaveAsync(Monitor monitor);
    Task<Monitor> UpdateAsync(int id, Monitor monitor);
    Task<Monitor> DeleteAsync(int id);
}