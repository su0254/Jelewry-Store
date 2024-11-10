using Jelewry_Store.Controllers;
using Jelewry_Store.Entities;
using Jelewry_Store.Services;
using Microsoft.AspNetCore.Mvc;

namespace TestJelewry_Store
{
    public class UnitTest1
    {
        [Fact]
        public void GetAllUsers_ReturnsOk()
        {
            var user = new UserController();
            var result = user.Get();
            Assert.Equal(0, result.Value.Count);
        }
        [Fact]
        public void GetById_ReturnsOk()
        {
            //Arrange
            var id = "3277";

            //Act
            var user = new UserController();
            var result = user.Get(id);

            //Assert
            Assert.True(result.Value is User || result.Value == null);
        }
        [Fact]
        public void PostUser_ReturnFalse()
        {
            //Arrange
            var u = new User();

            //Act
            var user = new UserController();
            var result = user.Post(u);

            //Assert
            Assert.True(!result.Value);
        }

        [Fact]
        public void UpdateUser_ReturnTrue() 
        {
            var tz = "327774881";
            var u = new User();
            var user = new UserController();
            var result = user.Put(tz, u);
            Assert.True(!result.Value);
        }

        [Fact]
        public void DeleteUser_ReturnFalse()
        {
            var tz = "1234";
            var u = new User();
            var user = new UserController();
            var result = user.Delete(tz);
            Assert.True(!result.Value);
        }
    }
}