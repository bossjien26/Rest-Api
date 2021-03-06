using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using RestApi.Controllers;
using RestApi.Models.Requests;
using Services;

namespace RestApi.Test.Controllers
{
    [TestFixture]
    public class SpecificationControllerTest : BaseController
    {
        private readonly SpecificationController _controller;

        public SpecificationControllerTest()
        {
            _controller = new SpecificationController(
                _context,
                new Mock<ILogger<SpecificationController>>().Object
            );
        }

        [Test]
        public async Task ShouldInsertSpecification()
        {
            var request = new CreateSpecificationRequest()
            {
                Name = "123"
            };

            var response = await _httpClient.PostAsync("/api/specification", PostType(request));

            //Assert
            Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);
        }

        [Test]
        public async Task ShouldInsertSpecificationContent()
        {
            var specificationService = new SpecificationService(_context);
            var request = new CreateSpecificationContentRequest()
            {
                Name = "123",
                SpecificationId = specificationService.GetMany(1, 1).First().Id
            };

            var response = await _httpClient.PostAsync("/api/specification/store/specificationContent", PostType(request));

            //Assert
            Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);
        }
    }
}