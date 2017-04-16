using System.Web.Mvc;
using NUnit.Framework;
using Practice.Web;
using System;
using Practice.Web.Controllers;

namespace Practice.Test
{
    [TestFixture]
    public class CustomerControllerUnitTests
    {
        [Test]
        public void Index_Returns_ActionResult()
        {
            //Arrange
            CustomerController controller = new CustomerController();

            var actual = controller.Index();


             
        }
    }
}
