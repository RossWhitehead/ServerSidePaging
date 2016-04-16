using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServerSidePaging.Controllers;
using ServerSidePaging.Service.Interfaces;
using AutoMapper;
using Moq;
using Ploeh.AutoFixture;
using ServerSidePaging.Service.Dtos;
using System.Linq.Expressions;
using ServerSidePaging.Model;
using System.Web.Mvc;
using ServerSidePaging.ViewModels;
using System.Linq;
using Framework.Data;

namespace ServerSidePaging.Tests.Controllers
{
    [TestClass]
    public class ProductControllerTests
    {
        private ProductController sut;
        private PageOfProductsDto pageOfProductsDto;
        private Mock<IProductService> mockProductService;
        private Expression<Func<IProductService, PageOfProductsDto>> getProductsExpression;

        [TestInitialize]
        public void TestInitialize()
        {
            // Arrange
            var fixture = new Fixture();
            fixture.Behaviors.Add(new OmitOnRecursionBehavior());
            pageOfProductsDto = fixture.Create<PageOfProductsDto>();

            var mockMapper = new Mock<IMapper>();

            mockProductService = new Mock<IProductService>();

            getProductsExpression = ps => ps.GetProducts(
                It.IsAny<Expression<Func<Product, bool>>>(),
                It.IsAny<int>(),
                It.IsAny<int>(),
                It.IsAny<SortExpression<Product>>(),
                It.IsAny<SortExpression<Product>>());

            mockProductService.Setup(getProductsExpression).Returns(pageOfProductsDto);

            this.sut = new ProductController(mockMapper.Object, mockProductService.Object);
        }

        [TestMethod]
        public void IndexReturnsViewAndViewModel()
        {
            // Arrange

            // Act
            var result = (ViewResult)sut.Index();
            var model = (ProductIndexVM)result.Model;
            var expectedProducts = pageOfProductsDto.Products.ToList();

            // Assert
            mockProductService.Verify<PageOfProductsDto>(getProductsExpression, Times.Once(), "Failed to call ProductService.GetProducts.");
            Assert.AreEqual<string>(MVC.Product.Views.ViewNames.Index, result.ViewName, "Index view is not being returned.");
            Assert.AreEqual<int>(pageOfProductsDto.Products.Count(), model.Products.Count(), "Index view does not return the correct number of products.");
            for (int i = 0; i < expectedProducts.Count(); i++)
            {
                Assert.AreEqual<int>(expectedProducts[i].ProductId, model.Products[i].ProductId, string.Format("Product {0} does not match.", i.ToString()));
            }
        }
    }
}
