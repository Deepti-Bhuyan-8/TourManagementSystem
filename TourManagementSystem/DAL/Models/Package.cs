using System.ComponentModel.DataAnnotations;

namespace TourManagementSystem.DAL.Models
{
    public class Package
    {
        [Key]
        public int PackageId { get; set; }
        public string PackageName { get; set; }
        public string Description { get; set; }
        public DateTime TourDate { get; set; }
        public decimal Price { get; set; }
        public int CarId { get; set; }
        public bool IsCarAvailable { get; set; }

        public ICollection<Booking> Bookings { get; set;}
    }
}
