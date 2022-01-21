using System;
using System.Threading.Tasks;
using Core.Interfaces;
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
            _accessor = new Mock<IHttpContextAccessor>();
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
        
        
    }
}