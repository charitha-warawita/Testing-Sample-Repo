    namespace AutoMapper.Core.API.Models
{
    public class CalendarEventForm
    {
        public DateTime EventDate { get; set; }
        public int EventHour { get; set; }
        public int EventMinute { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
    }
}
