using Microsoft.VisualStudio.TestTools.UnitTesting;
using BST.Services;
using BST.Models;

namespace BST_Test
{
    [TestClass]
    public class AuthenticationTests
    {
        private AuthenticationService authService;

        [TestInitialize]
        public void Setup()
        {
            authService = new AuthenticationService();
        }


        [TestMethod]
        public void Register_DuplicateUser_ReturnsFalse()
        {
            authService.Register("testuser2", "test2@email.com", "1234");

            bool result = authService.Register("testuser2", "test2@email.com", "1234");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Login_ValidCredentials_ReturnsUser()
        {
            authService.Register("loginuser", "login@email.com", "1234");

            User user = authService.Login("login@email.com", "1234");

            Assert.IsNotNull(user);
        }

 
        [TestMethod]
        public void Login_InvalidPassword_ReturnsNull()
        {
            authService.Register("user3", "user3@email.com", "1234");

            User user = authService.Login("user3@email.com", "wrong");

            Assert.IsNull(user);
        }

        [TestMethod]
        public void Login_UserDoesNotExist_ReturnsNull()
        {
            User user = authService.Login("fake@email.com", "1234");

            Assert.IsNull(user);
        }
    }
}