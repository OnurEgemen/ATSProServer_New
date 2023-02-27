﻿using ATSProServer.Domain.Abstractions;
using System.Linq.Expressions;

namespace ATSProServer.Domain.Repositories.GenericRepositories
{
    public interface IQueryGenericRepository<T>
        where T : Entity
    {
        IQueryable<T> GetAll(bool isTracking = true);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> expression, bool isTracking = true);
        Task<T> GetById(string id, bool isTracking = true);
        Task<T> GetFirstByExpression(Expression<Func<T, bool>> expression,CancellationToken 
            cancellationToken = default, bool isTracking = true);
        Task<T> GetFirst(bool isTracking = true);

    }
}
