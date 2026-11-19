using System.ComponentModel.DataAnnotations;

namespace TicketBookingSystem.Dtos.Event
{
    public record UpdateEvent
    {
        [Required]
        [StringLength(50)]
        public string? EventName { get; set; }
        [Required]
        [StringLength(500)]
        public string? EventDescription { get; set; }
        [Required]
        public string? EventCategorey { get; set; }
        [Required]
        public DateTime? EventDate { get; set; }
        [Required]
        public DateTime? StartTime { get; set; }
        [Required]
        public DateTime? EndTime { get; set; }


    }
}
