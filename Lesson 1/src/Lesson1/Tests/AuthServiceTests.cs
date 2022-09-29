using Lesson1.Architecture.Services;
using NUnit.Framework;

namespace Tests
{
    public class AuthServiceTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("Иванов")]
        [TestCase("Петров")]
        [TestCase("Сидоров")]
        public void Login_ShouldReturnTrue(string lastName)
        {
            // arrange

            var service = new AuthService();

            // act
            var result = service.Login(lastName);

            // assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Login_ShouldReturnTrue()
        {
            // arrange
            var lastName = "Иванов";

            var service = new AuthService();

            // act
            var result = service.Login(lastName);
            result = service.Login(lastName);

            // assert
            Assert.IsTrue(result);
        }

        [TestCase("")]
        [TestCase(null)]
        [TestCase("TestUser")]
        [Test]
        public void Login_ShouldReturnFalse(string lastName)
        {
            // arrange

            var service = new AuthService();

            // act
            var result = service.Login(lastName);

            // assert
            Assert.IsFalse(result);
        }
    }
}