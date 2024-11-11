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
            Assert.Equal(1, result.Value.Count);
        }
        [Fact]
        public void GetById_ReturnsOk()
        {
            //Arrange
            var id = "327774881";
            //Act
            var user = new UserController();
            var result = user.Get(id);
            //Assert
            Assert.IsType<User>(result.Value);
        }
        [Fact]
        public void GetById_ReturnsNotFoundTz()
        {
            //Arrange
            var tz = "32777";
            //Act
            var user = new UserController();
            var result = user.Get(tz);
            //Assert
            Assert.Null(result.Value);
        }
        [Fact]
        public void GetById_ReturnsBadRequest()
        {
            //Arrange
            string tz=null ;
            //Act
            var user = new UserController();
            var result = user.Get(tz);
            //Assert
            Assert.Null(result.Value);
        }
        [Fact]
        public void PostUser_ReturnTrue()
        {
            //Arrange
            var u = new User();
            //Act
            var user = new UserController();
            var result = user.Post(u);
            //Assert
            Assert.True(result.Value);
        }

        [Fact]
        public void UpdateUser_ReturnTrue() 
        {
            var tz = "327774881";
            var u = new User();
            var user = new UserController();
            var result = user.Put(tz, u);
            Assert.True(result.Value);
        }
        [Fact]
        public void UpdateUser_ReturnsNotFound()
        {
            //Arrange
            var tz = "32777";
            User u = new User();
            //Act
            var user = new UserController();
            var result = user.Put(tz,u);
            //Assert
            Assert.False(result.Value);
        }

        [Fact]
        public void UpdateUser_ReturnsBadRequest()
        {
            //Arrange
            string tz = null;
            User u = new User();
            //Act
            var user = new UserController();
            var result = user.Put(tz,u);
            //Assert
            Assert.False(result.Value);
        }

        [Fact]
        public void DeleteUser_ReturnTrue()
        {
            var tz = "327774881";
            var user = new UserController();
            var result = user.Delete(tz);
            Assert.True(result.Value);
        }
        [Fact]
        public void DeleteUser_ReturnsNotFoundTz()
        {
            //Arrange
            var tz = "32777";
            //Act
            var user = new UserController();
            var result = user.Delete(tz);
            //Assert
            Assert.False(result.Value);
        }
        [Fact]
        public void DeleteUser_ReturnsBadRequest()
        {
            //Arrange
            string tz = null;
            //Act
            var user = new UserController();
            var result = user.Delete(tz);
            //Assert
            Assert.False(result.Value);
        }
    }
}