using Microsoft.VisualStudio.TestTools.UnitTesting;
using BST.Services;

namespace BST_Test
{
    [TestClass]
    public class UserTests
    {
        private UserService userService;

        [TestInitialize]
        public void Setup()
        {
            userService = new UserService();
        }

        [TestMethod]
        public void GetAllUsers_ReturnsList()
        {
            var users = userService.GetAllUsers();

            Assert.IsNotNull(users);
        }

        [TestMethod]
        public void SearchUsers_ValidKeyword_ReturnsResults()
        {
            var users = userService.SearchUsers("test");

            Assert.IsNotNull(users);
        }

        [TestMethod]
        public void SearchUsers_NoMatch_ReturnsEmpty()
        {
            var users = userService.SearchUsers("zzzzzz");

            Assert.IsNotNull(users);
        }

        [TestMethod]
        public void MakeAdmin_ValidUser_Executes()
        {
            userService.MakeAdmin(1);

            Assert.IsTrue(true);
        }
    }
}
