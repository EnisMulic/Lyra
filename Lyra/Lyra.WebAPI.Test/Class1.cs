using Lyra.WebAPI.Controllers;
using Lyra.WebAPI.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using AutoMapper;
using Xunit;

namespace Lyra.WebAPI.Test
{
    
    public class Class1 : TestDatabase
    {
        [Fact]
        public async void Test()
        {
            var moqMap = new Mock<IMapper>();
            moqMap.Setup(m => m.Map<Model.User, Database.User>(It.IsAny<Model.User>())).Returns(new Database.User());

            var service = new UserService(_context, moqMap.Object);
            var controller = new UserController(service);

            var user = await controller.Get(null);

            Xunit.Assert.True(user.Count == 2);
        }
    }
}
