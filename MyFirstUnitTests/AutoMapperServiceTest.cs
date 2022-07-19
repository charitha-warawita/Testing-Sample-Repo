using AutoMapper.Core.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstUnitTests
{
    public class MapperServiceTest
    {
        [Fact]
        public void GetTransformedModelTitleTest() 
        {
            MapperService mapper = new MapperService();
            var result = mapper.GetTransformedModel();

            Assert.Equal("Company Holiday Party HCL", result.Title);
        }

        [Fact]
        public void GetTransformedModelNameTest()
        {
            MapperService mapper = new MapperService();
            var result = mapper.GetTransformedModel();

            Assert.Contains("Event", result.Name);
        }
    }
}
