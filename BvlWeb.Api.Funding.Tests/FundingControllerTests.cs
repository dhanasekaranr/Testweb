using NUnit.Framework;
using BvlWeb.Api.Funding.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using BvlWeb.Modules.Funding.Models.Dto;
using BvlWeb.Modules.Funding.Interfaces;

namespace BvlWeb.Api.Funding.Tests
{
    [TestFixture]
    public class FundingControllerTests
    {
        [Test]
        public void Get_ReturnsOkResult_WithValidData()
        {
            // Arrange
            var mockService = new Mock<IFundingService>(MockBehavior.Strict, null);
            mockService.Setup(s => s.GetFunding(It.IsAny<int>()))
                .Returns(new FundingDto { Id = 1, Name = "Test Funding" });
            var controller = new FundingController(mockService.Object);

            // Act
            var result = controller.Get(1);

            // Assert
            Assert.That(result, Is.InstanceOf<OkObjectResult>());
        }
    }
}
