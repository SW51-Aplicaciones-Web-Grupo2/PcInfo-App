using PCInfo_backend.Recommendations.Domain.Models;
using PCInfo_backend.Recommendations.Domain.Services.Communication;

namespace PCInfo_backend.Recommendations.Domain.Services;

public interface IDiscoDuroService
{
    Task<IEnumerable<DiscoDuro>> ListAsync();
    Task<DiscoDuroResponse> SaveAsync(DiscoDuro discoDuro);
    Task<DiscoDuroResponse> UpdateAsync(int id, DiscoDuro discoDuro);
    Task<DiscoDuroResponse> DeleteAsync(int id);
}