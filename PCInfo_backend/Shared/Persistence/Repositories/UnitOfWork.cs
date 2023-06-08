using PCInfo_backend.Recommendations.Domain.Repositories;
using PCInfo_backend.Shared.Persistence.Contexts;

namespace PCInfo_backend.Shared.Persistence.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }

    public async Task completeAsync()
    {
        await _context.SaveChangesAsync();
    }
}