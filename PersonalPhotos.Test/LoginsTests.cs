using System;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Xunit;
using Moq;
using PersonalPhotos.Controllers;
using PersonalPhotos.Models;

namespace PersonalPhotos.Test
{
    public class LoginTests
    {
        private readonly LoginsController _controller;
        private readonly Mock<ILogins> _logins;
        private readonly Mock<IHttpContextAccessor> _accessor;

        public LoginTests()
        {
            _logins = new Mock<ILogins>();

            var session = Mock.Of<ISession>();
            var httpContext = Mock.Of<HttpContext>(x => x.Session == session);
            
            _accessor = new Mock<IHttpContextAccessor>();
            _accessor.Setup(x => x.HttpContext).Returns(httpContext);
            _controller = new LoginsController(_logins.Object, _accessor.Object);
        }
        
        [Fact]
        public void Index_GivenNoReturnURL_ReturnLoginView()
        {
            var result = (_controller.Index() as ViewResult);
            //Assert.IsAssignableFrom<IActionResult>(result);
            //Assert.IsType<ViewResult>(result)
            Assert.NotNull(result); // something is coming back
            Assert.Equal("Login", result.ViewName, ignoreCase: true); //the Login view is coming back
        }

        [Fact]
        public async Task LoginModelStateInvalid_ReturnLoginView()
        {
            _controller.ModelState.AddModelError("Test", "Test");

            var result = await _controller.Login(Mock.Of<LoginViewModel>()) as ViewResult;
            Assert.Equal("Login", result.ViewName, ignoreCase:true);
        }

        [Fact]
        public async Task Login_GivenCorrectPassword_RedirectToDisplayAction()
        {
            const string password = "123";
            var modelView = Mock.Of<LoginViewModel>(x => x.Email == "a@b.com" && x.Password == password);
            var model = Mock.Of<User>(x => x.Password == password);

            _logins.Setup(x => x.GetUser(It.IsAny<string>())).ReturnsAsync(model);

            var result = await _controller.Login(modelView);
            Assert.IsType<RedirectToActionResult>(result);
        }
        
        //write test for when password doesn't match you get redirected to login view
        
    }
}