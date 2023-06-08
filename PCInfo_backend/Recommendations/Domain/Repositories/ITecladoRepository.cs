using PCInfo_backend.Recommendations.Domain.Models;

namespace PCInfo_backend.Recommendations.Domain.Repositories;

public interface ITecladoRepository
{
    Task<IEnumerable<Teclado>> ListAsync();
    Task AddAsync(Teclado teclado);
    Task<Teclado> FindByIdAsync(int id);
    void Update(Teclado teclado);
    void Remove(Teclado teclado);
    
}