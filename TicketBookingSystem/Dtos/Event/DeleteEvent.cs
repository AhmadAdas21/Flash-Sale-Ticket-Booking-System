using System.ComponentModel.DataAnnotations;

namespace TicketBookingSystem.Dtos.Event
{
    public record DeleteEvent
    {
        [Required]
        public int EventId { get; set; }
    }
}
