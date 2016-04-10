using ServerSidePaging.Model;
using Framework.Data;
using Framework.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ServerSidePaging.Service.Interfaces
{
    public interface IProductService : IService
    {
       IEnumerable<Product> GetProducts(Expression<Func<Product, bool>> filter, int page, int pageSize, params SortExpression<Product>[] sortExpressions);
    }
}
