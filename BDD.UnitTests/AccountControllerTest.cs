using System.Web.Mvc;
using BDD.Web.Controllers;
using FluentAssertions;
using NUnit.Framework;

namespace BDD.UnitTests
{

    [TestFixture]
  public  class AccountControllerTest
    {

        [Test]
      public void Account_Controller_Ctor_Should_Created()
      {
          // Arrange


          // Act
          AccountController accountController = new AccountController();

          // Assert
          accountController.Should().NotBeNull();

      }


        [Test]
      public void Register_Get_Should_Return_Register_View()
      {
          // Arrange
          AccountController accountController = new AccountController();

          // Act
            ViewResult result = accountController.Register() as ViewResult;

          // Assert
            result.ViewName.Should().Be("Register");

      }


        [Test]
        public void Register_Post_Should_Return_Redirect_To_Register()
        {
            // Arrange
            AccountController accountController = new AccountController();

            // Act
            RedirectToRouteResult result = accountController.Register("wangdeshui@gmail.com", "123abc") as RedirectToRouteResult;

            // Assert
            result.RouteValues["action"].Should().Be("Register");

        }


        [Test]
        public void Register_Post_TempData_Should_Be_Success()
        {
            // Arrange
            AccountController accountController = new AccountController();

            // Act
            accountController.Register("wangdeshui@gmail.com", "123abc");

            // Assert
            accountController.TempData["Success"].Should().Be("Thank you for registering");

        }

    }
}
