using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasLibrary;
using NUnit.Framework;

namespace TugasLibraryUnitTest
{
    [TestFixture]
    public class UserTest
    {
        private User user;
        [SetUp]
        public void Init()
        {
            user = new User();
        }
        [Test]
        public void NotValidUserTest()
        {
            string UserName = "admin";
            string Password = "passwordsalah";

            bool actual = user.IsValidUser(UserName, Password);
            Assert.IsFalse(actual);
        }
        [Test]
        public void ValidUserTest()
        {
            string UserName = "admin";
            string Password = "admin";
            bool actual = user.IsValidUser(UserName, Password);
            Assert.IsTrue(actual);
        }
    }
}
