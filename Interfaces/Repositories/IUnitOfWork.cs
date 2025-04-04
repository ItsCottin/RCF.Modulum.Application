﻿using RCF.Modulum.Domain.Contracts;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace modulum.Application.Interfaces.Repositories
{
    public interface IUnitOfWork<TId> : IDisposable
    {
        Task<int> Commit(CancellationToken cancellationToken);

        Task<int> CommitAndRemoveCache(CancellationToken cancellationToken, params string[] cacheKeys);

        Task Rollback();
    }
}