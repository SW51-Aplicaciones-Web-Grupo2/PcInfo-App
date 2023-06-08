using PCInfo_backend.Recommendations.Domain.Models;
using PCInfo_backend.Recommendations.Domain.Services.Communication;

namespace PCInfo_backend.Recommendations.Domain.Services;

public interface ICPUService
{
    Task<IEnumerable<CPU>> ListAsync();
    Task<CPUResponse> SaveAsync(CPU cpu);
    Task<CPUResponse> UpdateAsync(int id, CPU cpu);
    Task<CPUResponse> DeleteAsync(int id);
}