using Framework.Data;
using Framework.Service;
using ServerSidePaging.Model;
using ServerSidePaging.Service.Dtos;
using System;
using System.Linq.Expressions;

namespace ServerSidePaging.Service.Interfaces
{
    public interface IProductService : IService
    {
        PageOfProductsDto GetProducts(Expression<Func<Product, bool>> filter, int page, int pageSize, params SortExpression<Product>[] sortExpressions);
    }
}
