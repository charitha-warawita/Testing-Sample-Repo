using AutoMapper.Core.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstUnitTests.Services
{
    public class MapperServiceTest
    {
        private readonly MapperService mapper;
        public MapperServiceTest()
        {
            mapper = new MapperService();
        }
        [Fact]
        public void GetTransformedModelTitleTest()
        {
            var result = mapper.GetTransformedModel();

            Assert.Equal("Company Holiday Party HCL", result.Title);
        }

        [Fact]
        public void GetTransformedModelNameTest()
        {
            var result = mapper.GetTransformedModel();

            Assert.Contains("Event", result.Name);
        }
    }
}
