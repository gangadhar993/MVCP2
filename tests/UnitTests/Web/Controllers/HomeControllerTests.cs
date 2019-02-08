using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers;
using Xunit;

using Web;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using System.Net.Http;


// Important: Make sure namespace matches folder structure
namespace Tests.UnitTests.Web.Controllers
{
    public class HomeControllerTests
    {

   // these are not async Tasks, just void methods
       [Fact]
        public  void Index_ReturnsAView()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index();

            // Assert
	
            var actual = Assert.IsAssignableFrom<IActionResult>(result);
            Assert.NotNull(actual);
        }

		

       [Fact]
        public void calculateSalary()
        {
            double wageRate = 11.25;
            int hours = 9;
            var expected = 101.25;
            var actual = calcSalary(wageRate, hours);
		    Assert.Equal(expected, actual);
        }



        double calcSalary(double wageRate, int hours)
        {
            if (hours <= 0 || wageRate <= 0)
            {
                return 0;
            }
            else
            {
                return wageRate * hours;
            }
        }


      
     
    }
}