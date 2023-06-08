using PCInfo_backend.Recommendations.Domain.Models;

namespace PCInfo_backend.Recommendations.Domain.Repositories;

public interface IProductoRepository
{
    Task<IEnumerable<Producto>> ListAsync();
    Task AddAsync(Producto producto);
    Task<Producto> FindByIdAsync(int id);
    void Update(Producto producto);
    void Remove(Producto producto);
}