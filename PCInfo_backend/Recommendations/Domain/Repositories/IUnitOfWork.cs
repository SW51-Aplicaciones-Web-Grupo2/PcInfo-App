namespace PCInfo_backend.Recommendations.Domain.Repositories;

public interface IUnitOfWork
{
    Task completeAsync();
}