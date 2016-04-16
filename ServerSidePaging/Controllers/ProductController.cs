using AutoMapper;
using Framework.Data;
using ServerSidePaging.Model;
using ServerSidePaging.Service.Dtos;
using ServerSidePaging.Service.Interfaces;
using ServerSidePaging.ViewModels;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;

namespace ServerSidePaging.Controllers
{
    public partial class ProductController : Controller
    {
        private IMapper mapper;
        private IProductService productService;

        public ProductController(IMapper mapper, IProductService productService)
        {
            this.mapper = mapper;
            this.productService = productService;
        }

        public virtual ActionResult Index()
        {
            var pageOfProductsDto = this.productService.GetProducts(
                p => p.Price > 1000,
                2,
                2,
                new SortExpression<Product>(p => p.Name, ListSortDirection.Ascending),
                new SortExpression<Product>(p => p.Description, ListSortDirection.Descending));

            var vm = new ProductIndexVM { Products = pageOfProductsDto.Products.ToList(), Page = 2, TotalCount = pageOfProductsDto.TotalCount };

            return View(Views.ViewNames.Index, vm);
        }
    }
}