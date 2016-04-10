using DataTables.Mvc;
using Framework.Data;
using ServerSidePaging.Data.Interfaces;
using ServerSidePaging.Model;
using ServerSidePaging.Service.Interfaces;
using ServerSidePaging.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace ServerSidePaging.Controllers
{
    public class ProductController : Controller
    {
        private IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        public ActionResult Index()
        {
            List<Product> products = this.productService.GetProducts(
                p => p.Price > 1000,
                2,
                2,
                new SortExpression<Product>(p => p.Name, ListSortDirection.Ascending),
                new SortExpression<Product>(p => p.Description, ListSortDirection.Descending)).ToList();

            ProductPageVM vm = new ProductPageVM { Products = products, Page = 2 };

            return View(vm);
        }
    }
}