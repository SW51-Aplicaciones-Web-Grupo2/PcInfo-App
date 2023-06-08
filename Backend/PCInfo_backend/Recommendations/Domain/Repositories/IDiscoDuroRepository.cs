using PCInfo_backend.Recommendations.Domain.Models;

namespace PCInfo_backend.Recommendations.Domain.Repositories;

public interface IDiscoDuroRepository
{
    Task<IEnumerable<DiscoDuro>> ListAsync();
    Task AddAsync(DiscoDuro discoDuro);
    Task<DiscoDuro> FindByIdAsync(int id);
    void Update(DiscoDuro discoDuro);
    void Remove(DiscoDuro discoDuro);
    
}