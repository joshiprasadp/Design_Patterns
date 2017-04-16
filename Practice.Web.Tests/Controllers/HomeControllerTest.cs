using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Practice.Web;
using Practice.Web.Controllers;
using NUnit.Framework;
using Moq;
using Practice.Web.Models;

namespace Practice.Web.Tests.Controllers
{
    [TestFixture()]
    public class HomeControllerTest
    {
        //[Test]
        //public void Index()
        //{
        //    // Arrange
        //    HomeController controller = new HomeController();

        //    // Act
        //    ViewResult result = controller.Index() as ViewResult;

        //    // Assert
        //    //Assert.IsNotNull(result);
        //    Assert.IsInstanceOf<ActionResult>(result);
        //}

        [Test]
        public void Customer_Index_View_Contains_ListofCustomer_Model()
        {
            //Arrange
            Mock<ICustomerRepository> mock = new Mock<ICustomerRepository>();
            mock.Setup(m => m.Customers).Returns(new Customer[]
                {
                    new Customer { Age = "20", CustId = 1001, Name = "Test1" },
                    new Customer { Age = "21", CustId = 1001, Name = "Test2" }
                }.AsQueryable());

            var controller = new CustomersController(mock.Object);

            //Act
            var actual = (List<Customer>)controller.Index().Model;

            //Assert
            Assert.IsInstanceOf<List<Customer>>(actual);
        }
    }
}
