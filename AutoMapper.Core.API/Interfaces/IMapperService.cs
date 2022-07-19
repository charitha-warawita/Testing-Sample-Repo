using AutoMapper.Core.API.Models;

namespace AutoMapper.Core.API.Interfaces
{
    public interface IMapperService
    {
        public CalendarEventForm GetTransformedModel();
        public string GetTransformedModelString();
    }
}
