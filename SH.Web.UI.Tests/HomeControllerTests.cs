using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using NUnit.Framework;
using SH.Web.UI;
using SH.Web.UI.Controllers;

namespace SH.Web.UI.Tests
{
    public class HomeControllerTests
    {
        
        [Test]
        public void Index_Returns_ViewResult()
        {
            var controller = new HomeController();

            var result = controller.Index() as ViewResult;

            Assert.That(result.ViewName, Is.EqualTo("Index"));
        }
    }
}
