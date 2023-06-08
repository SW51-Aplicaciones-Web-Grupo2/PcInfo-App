using PCInfo_backend.Recommendations.Domain.Models;

namespace PCInfo_backend.Recommendations.Domain.Repositories;

public interface IMouseRepository
{
    Task<IEnumerable<Mouse>> ListAsync();
    Task AddAsync(Mouse mouse);
    Task<Mouse> FindByIdAsync(int id);
    void Update(Mouse mouse);
    void Remove(Mouse mouse);
    
}