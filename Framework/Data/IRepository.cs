using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Framework.Data
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> Get();

        IEnumerable<TEntity> Get(
           Expression<Func<TEntity, bool>> filter = null);

        IEnumerable<TEntity> Get(
           Expression<Func<TEntity, bool>> filter = null,
           string[] includePaths = null);

        IEnumerable<TEntity> Get(
           Expression<Func<TEntity, bool>> filter = null,
           string[] includePaths = null,
           int? page = 0,
           int? pageSize = null,
           params SortExpression<TEntity>[] sortExpressions);
    }
}