using System;

namespace MultiDataSourceGenericRepository.BL.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class;
        int Save();
    }
}