using System;
using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc.Testing;
using ApothecaryManager.Api;
using System.Net.Http;
using System.Threading.Tasks;
using ApothecaryManager.WebApi.Controllers;
using ApothecaryManager.Data;
using AutoMapper;
using ApothecaryManager.Api.Helpers;
using System.Web.Http;
using System.Collections.Generic;
using ApothecaryManager.Data.Model;
using System.Web.Http.Results;
using Microsoft.AspNetCore.Routing;
using System.Web.Http.Routing;
using System.Linq;

namespace ApothecaryManager.Tests
{
    public class ApiControllerDrugTests
    {
        private readonly IMapper mockMapper;

        public ApiControllerDrugTests()
        {
            var _mapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperProfile()); //your automapperprofile
            });
            mockMapper = _mapper.CreateMapper();
        }

        [Fact]
        public async Task GetAllDrugs_ShouldReturnList()
        {
            // Arrange
            var mockContext = new Mock<ShopDbContext>();
            var _controller = new DrugController(mockContext.Object, mockMapper);

            // Act
            var actionResult = _controller.GetAll();

            // Assert
            Assert.IsType<IEnumerable<Drug>>(actionResult);
        }

        [Fact]
        public void GetDrug_OnNotExisting_ReturnsNotFound()
        {
            // Arrange
            var mockContext = new Mock<ShopDbContext>();
            var _controller = new DrugController(mockContext.Object, mockMapper);

            // Act
            var actionResult = _controller.Get(10);

            // Assert
            Assert.IsType<System.Web.Http.Results.NotFoundResult>(actionResult);
        }

        [Fact]
        public void GetDrug_OnExisting_ReturnsOk()
        {
            // Arrange
            var mockContext = new Mock<ShopDbContext>();
            mockContext.Setup(
                x => x.Drugs.First(x => x.Id == 10)
                ).Returns(new Drug() {Id = 10});

            var _controller = new DrugController(mockContext.Object, mockMapper);

            // Act
            var actionResult = _controller.Get(10);

            // Assert
            Assert.IsType<System.Web.Http.Results.OkResult>(actionResult);
        }

    }
}
