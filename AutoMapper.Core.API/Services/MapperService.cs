using AutoMapper;
using AutoMapper.Core.API.Interfaces;
using AutoMapper.Core.API.Models;

namespace AutoMapper.Core.API.Services
{
    public class MapperService : IMapperService
    {
        public CalendarEventForm GetTransformedModel()
        {
            try
            {
                var calendarEvent = new CalendarEvent
                {
                    Date = DateTime.Now,
                    Title = "Company Holiday Party HCL",
                    Name = $"Event-{DateTime.Now.Millisecond}"
                };

                // Configure AutoMapper
                var configuration = new MapperConfiguration(cfg =>
                  cfg.CreateMap<CalendarEvent, CalendarEventForm>()
                    .ForMember(dest => dest.EventDate, opt => opt.MapFrom(src => src.Date.Date))
                    .ForMember(dest => dest.EventHour, opt => opt.MapFrom(src => src.Date.Hour))
                    .ForMember(dest => dest.EventMinute, opt => opt.MapFrom(src => src.Date.Minute)));

                // Perform mapping
                var mapper = configuration.CreateMapper(); 
                CalendarEventForm form = mapper.Map<CalendarEvent, CalendarEventForm>(calendarEvent);
                
                return form;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string GetTransformedModelString()
        {
            return "Success";
        }
    }
}
