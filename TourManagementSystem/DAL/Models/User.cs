using System.ComponentModel.DataAnnotations;

namespace TourManagementSystem.DAL.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}
