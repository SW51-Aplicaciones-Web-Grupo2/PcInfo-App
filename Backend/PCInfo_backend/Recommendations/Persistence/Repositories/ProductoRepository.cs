using Microsoft.EntityFrameworkCore;
using PCInfo_backend.Recommendations.Domain.Models;
using PCInfo_backend.Recommendations.Domain.Repositories;
using PCInfo_backend.Shared.Persistence.Contexts;
using PCInfo_backend.Shared.Persistence.Repositories;

namespace PCInfo_backend.Recommendations.Persistence.Repositories;

public class ProductoRepository : BaseRepository, IProductoRepository
{
    public ProductoRepository(AppDbContext context) : base(context)
    {
    }
    
    public async Task<IEnumerable<Producto>> ListAsync()
    {
        return await _context.Productos.ToListAsync();
    }
    public async Task AddAsync(Producto producto)
    {
        await _context.Productos.AddAsync(producto);
    }
    public async Task<Producto> FindByIdAsync(int id)
    {
        return await _context.Productos.FindAsync(id);
    }
    public void Update(Producto producto)
    {
        _context.Productos.Update(producto);
    }
    public void Remove(Producto producto)
    {
        _context.Productos.Remove(producto);
    }
}