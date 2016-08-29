using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.QualityTools.Testing.Fakes;

namespace Logging.Tests
{
    [TestClass]
    public class UserUnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var id = Guid.NewGuid();
            var firstName = "FirstName";
            var lastName = "lastName";
            var userRepository = new Fakes.StubIUserRepository();
            userRepository.AddUser = (user) =>
            {
                Assert.AreEqual(firstName, user.FirstName);
                Assert.AreEqual(lastName, user.LastName);
            };
            var userRepo = new UserRepo(userRepository);

            var createdUser = default(User);
            using (ShimsContext.Create())
            {
                createdUser = userRepo.CreateUser(firstName, lastName);
            }

            Assert.AreEqual(firstName, createdUser.FirstName);
            Assert.AreEqual(lastName, createdUser.LastName);
        }
    }
}
