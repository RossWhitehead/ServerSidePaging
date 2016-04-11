using Framework.Data;
using Framework.Service;
using ServerSidePaging.Data.Interfaces;
using ServerSidePaging.Model;
using ServerSidePaging.Service.Dtos;
using ServerSidePaging.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BikeStore.Service
{
    public class ProductService : IProductService
    {
        private IServerSidePagingUnitOfWork unitOfWork;
        private IValidationDictionary validatonDictionary;

        public ProductService(IServerSidePagingUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Initialize(IValidationDictionary validationDictionary)
        {
            this.validatonDictionary = validationDictionary;
        }

        public PageOfProductsDto GetProducts(Expression<Func<Product, bool>> filter, int page, int pageSize, params SortExpression<Product>[] sortExpressions)
        {
            IEnumerable<Product> products = this.unitOfWork.ProductRepository.Get(
                filter,
                new string[] { "ProductCategory" },
                page,
                pageSize,
                sortExpressions);

            return new PageOfProductsDto() { Products = products, TotalCount = 6};        
        }
    }
}
