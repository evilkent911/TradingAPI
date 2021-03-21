using InterviewQuestionTradingAPI.Controllers;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;

namespace InterviewQuestionTradingAPI.Test.Controllers
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestGet()
        {
            //Arrange
            var mockDi = new Mock<ILogger<SymbolsController>>();
            var controller = new SymbolsController(mockDi.Object);

            // action

            var output = controller.Get();

            //assert 
            Assert.IsNotEmpty(output);

        }
    }
}