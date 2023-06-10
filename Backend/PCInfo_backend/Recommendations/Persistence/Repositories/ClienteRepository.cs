using Microsoft.EntityFrameworkCore;
using PCInfo_backend.Recommendations.Domain.Models;
using PCInfo_backend.Recommendations.Domain.Repositories.Users;
using PCInfo_backend.Shared.Persistence.Contexts;
using PCInfo_backend.Shared.Persistence.Repositories;

namespace PCInfo_backend.Recommendations.Persistence.Repositories;

public class ClienteRepository : BaseRepository, IClienteRepository
{
    public ClienteRepository(AppDbContext context) : base(context)
    {
    }
    
    public async Task<IEnumerable<Cliente>> ListAsync()
    {
        return await _context.Clientes.ToListAsync();
    }
    public async Task AddAsync(Cliente cliente)
    {
        await _context.Clientes.AddAsync(cliente);
    }
    public async Task<Cliente> FindByIdAsync(int id)
    {
        return await _context.Clientes.FindAsync(id);
    }
    public void Update(Cliente cliente)
    {
        _context.Clientes.Update(cliente);
    }
    public void Remove(Cliente cliente)
    {
        _context.Clientes.Remove(cliente);
    }
}