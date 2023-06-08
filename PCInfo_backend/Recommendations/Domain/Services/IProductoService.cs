using PCInfo_backend.Recommendations.Domain.Models;

namespace PCInfo_backend.Recommendations.Domain.Services;

public interface IProductoService
{
    Task<IEnumerable<Producto>> ListAsync();
    Task<Producto> GetAsync(int id);
    Task<Producto> SaveAsync(Producto producto);
    Task<Producto> UpdateAsync(int id, Producto producto);
    Task<Producto> DeleteAsync(int id);
}