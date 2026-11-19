namespace TicketBookingSystem.Models
{
    public class Events
    {
        public int EventId { get; set; }
        public string EventName { get; set; }=string.Empty;
        public string EventDescription { get; set; } = string.Empty;
        public string EventCategory { get; set; } = string.Empty;
        public DateTime EventDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string EventType { get; set; } = string.Empty;



    }
}
