using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServerSidePaging.Controllers;
using System.Web.Mvc;

namespace ServerSidePaging.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTests
    {
        private HomeController sut;

        [TestInitialize]
        public void TestInitialize()
        {
            this.sut = new HomeController();
        }

        [TestMethod]
        public void IndexReturnsView()
        {
            Assert.AreEqual<string>(
                ((ViewResult)this.sut.Index()).ViewName, 
                MVC.Home.Views.ViewNames.Index, 
                "Index view is not being returned.");
        }

        [TestMethod]
        public void AboutReturnsView()
        {
            Assert.AreEqual<string>(
                ((ViewResult)this.sut.About()).ViewName,
                MVC.Home.Views.ViewNames.About, 
                "About view is not being returned.");
        }

        [TestMethod]
        public void ContactReturnsView()
        {
            Assert.AreEqual<string>(
                ((ViewResult)this.sut.Contact()).ViewName, 
                MVC.Home.Views.ViewNames.Contact, 
                "Contact view is not being returned.");
        }
    }
}
