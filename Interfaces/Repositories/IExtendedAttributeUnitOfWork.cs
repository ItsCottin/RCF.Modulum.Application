﻿using System;
using System.Threading;
using System.Threading.Tasks;
using modulum.Domain.Contracts;

namespace modulum.Application.Interfaces.Repositories
{
    public interface IExtendedAttributeUnitOfWork<TId, TEntityId, TEntity> : IDisposable where TEntity : AuditableEntity<TEntityId>
    {
        IRepositoryAsync<T, TId> Repository<T>() where T : AuditableEntityExtendedAttribute<TId, TEntityId, TEntity>;

        Task<int> Commit(CancellationToken cancellationToken);

        Task<int> CommitAndRemoveCache(CancellationToken cancellationToken, params string[] cacheKeys);

        Task Rollback();
    }
}