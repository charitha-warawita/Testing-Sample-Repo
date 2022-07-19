using AutoMapper.Core.API.Controllers;
using AutoMapper.Core.API.Interfaces;
using AutoMapper.Core.API.Models;
using AutoMapper.Core.API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstUnitTests.Controllers
{
    public class MockMapperServiceTest
    {
        [Fact]
        public void GetMockResponseValueTest()
        {
            //MapperService mapper = new MapperService();
            //var result = mapper.GetTransformedModel();
            //Assert.Equal("Company Holiday Party HCL", result.Title);

            CalendarEventForm result = new CalendarEventForm
            {
                EventDate = DateTime.Now,
                EventHour = DateTime.Now.Hour,
                EventMinute = DateTime.Now.Minute,
                Name = $"Event-{DateTime.Now.Millisecond}",
                Title = "Company Holiday Party HCL"
            };

            var mapperServiceMock = new Mock<IMapperService>();
            mapperServiceMock.Setup(x => x.GetTransformedModel()).Returns(result);

            var loggerMock = new Mock<ILogger<WeatherForecastController>>();

            WeatherForecastController controller = new WeatherForecastController(loggerMock.Object, mapperServiceMock.Object);
            var finalResult = controller.GetMockResponse();

            var okResult = finalResult as OkObjectResult;
            var resultObject = (CalendarEventForm)okResult.Value;

            Assert.Equal(result, resultObject);
        }

        [Fact]
        public void GetMockResponseNotNullTest()
        {
            //MapperService mapper = new MapperService();
            //var result = mapper.GetTransformedModel();
            //Assert.Equal("Company Holiday Party HCL", result.Title);

            CalendarEventForm result = new CalendarEventForm
            {
                EventDate = DateTime.Now,
                EventHour = DateTime.Now.Hour,
                EventMinute = DateTime.Now.Minute,
                Name = $"Event-{DateTime.Now.Millisecond}",
                Title = "Company Holiday Party HCL"
            };

            var mapperServiceMock = new Mock<IMapperService>();
            mapperServiceMock.Setup(x => x.GetTransformedModel()).Returns(result);

            var loggerMock = new Mock<ILogger<WeatherForecastController>>();

            WeatherForecastController controller = new WeatherForecastController(loggerMock.Object, mapperServiceMock.Object);
            var finalResult = controller.GetMockResponse();

            var okResult = finalResult as OkObjectResult;
            var resultObject = (CalendarEventForm)okResult.Value;
            Assert.NotNull(resultObject);
        }

        [Fact]
        public void GetMockResponseStringTest()
        {
            var result = "Success";

            var mapperServiceMock = new Mock<IMapperService>();
            mapperServiceMock.Setup(x => x.GetTransformedModelString()).Returns(result);

            var loggerMock = new Mock<ILogger<WeatherForecastController>>();

            WeatherForecastController controller = new WeatherForecastController(loggerMock.Object, mapperServiceMock.Object);
            var finalResult = controller.GetMockResponseString();

            Assert.Equal("Success", finalResult);
        }
    }
}
