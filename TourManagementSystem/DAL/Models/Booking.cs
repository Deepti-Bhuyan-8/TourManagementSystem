using System.ComponentModel.DataAnnotations;

namespace TourManagementSystem.DAL.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }
        public int UserId { get; set; }
        public int PackageId { get; set; }
        public DateTime BookingDate { get; set; }
        public int NumOfTickets { get; set; }
        public Package Package { get; set; }
        public User User { get; set; }
    }
}
