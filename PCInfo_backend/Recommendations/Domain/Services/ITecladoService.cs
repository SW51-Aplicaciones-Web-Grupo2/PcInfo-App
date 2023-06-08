using PCInfo_backend.Recommendations.Domain.Models;

namespace PCInfo_backend.Recommendations.Domain.Services;

public interface ITecladoService
{
    Task<IEnumerable<Teclado>> ListAsync();
    Task<Teclado> GetAsync(int id);
    Task<Teclado> SaveAsync(Teclado teclado);
    Task<Teclado> UpdateAsync(int id, Teclado teclado);
    Task<Teclado> DeleteAsync(int id);
}