using PCInfo_backend.Recommendations.Domain.Models.Users;

namespace PCInfo_backend.Recommendations.Domain.Services;

public interface IUserService
{
    Task<IEnumerable<User>> ListAsync();
    Task<User> GetAsync(string id);
    Task<User> SaveAsync(User user);
    Task<User> UpdateAsync(string id, User user);
    Task<User> DeleteAsync(string id);
}