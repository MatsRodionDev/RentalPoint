using RentalPoint.Api.Interfaces.Entity;

namespace RentalPoint.Api.Interfaces.Repositories
{
    public interface IGenericRepository<TEntity>
       where TEntity : IBaseModel
    {
        Task<List<TEntity>> GetAllAsync(CancellationToken cancellationToken);
        Task<TEntity?> GetByIdAsync(int id, CancellationToken cancellationToken);
        Task AddAsync(TEntity model, CancellationToken cancellationToken);
        Task Update(TEntity model, CancellationToken cancellationToken);
        Task Delete(TEntity model, CancellationToken cancellationToken);
    }
}
