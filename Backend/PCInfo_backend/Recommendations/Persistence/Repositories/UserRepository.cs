using Microsoft.EntityFrameworkCore;
using PCInfo_backend.Recommendations.Domain.Models.Users;
using PCInfo_backend.Recommendations.Domain.Repositories.Users;
using PCInfo_backend.Shared.Persistence.Contexts;
using PCInfo_backend.Shared.Persistence.Repositories;

namespace PCInfo_backend.Recommendations.Persistence.Repositories;

public class UserRepository : BaseRepository, IUserRepository
{
    public UserRepository(AppDbContext context) : base(context)
    {
    }
    
    public async Task<IEnumerable<User>> ListAsync()
    {
        return await _context.Users.ToListAsync();
    }
    public async Task AddAsync(User user)
    {
        await _context.Users.AddAsync(user);
    }
    public Task<User> FindByIdAsync(string id)
    {
        throw new NotImplementedException();
    }
    public async Task<User> FindByIdAsync(int id)
    {
        return await _context.Users.FindAsync(id);
    }
    public void Update(User user)
    {
        _context.Users.Update(user);
    }
    public void Remove(User user)
    {
        _context.Users.Remove(user);
    }
}