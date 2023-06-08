namespace PCInfo_backend.Recommendations.Domain.Repositories;
using Monitor = PCInfo_backend.Recommendations.Domain.Models.Monitor;

public interface IMonitorRepository
{
    Task<IEnumerable<Monitor>> GetAllAsync();
    Task<Monitor> GetByIdAsync(int id);
    Task AddAsync(Monitor monitor);
    void Update(Monitor monitor);
    void Remove(Monitor monitor);
}