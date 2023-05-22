using TourManagementSystem.DAL.Models;

namespace TourManagementSystem.BLL.DTOs
{
    public class PackageDTO
    {
        

        public int PackageId { get; set; }
        public string PackageName { get; set; }
        public string Description { get; set; }
        public DateTime TourDate { get; set; }
        public decimal Price { get; set; }
        public int CarId { get; set; }
        private bool IsCarAvailable { get; set; }

        public ICollection<Booking> Bookings { get; set; }

        public static explicit operator Package(PackageDTO dto)
        {
            if (dto == null) return null;
            return new Package
            {
                PackageId = dto.PackageId,
                PackageName = dto.PackageName,
                Description = dto.Description,
                TourDate = dto.TourDate,
                Price = dto.Price,
                CarId = dto.CarId,
                IsCarAvailable = dto.IsCarAvailable,
                Bookings = dto.Bookings
            };
        }

        public static implicit operator PackageDTO(Package package)
        {
            if (package == null) return null;
            return new PackageDTO
            {
                PackageId = package.PackageId,
                PackageName = package.PackageName,
                Description = package.Description,
                TourDate = package.TourDate,
                Price = package.Price,
                CarId = package.CarId,
                IsCarAvailable = package.IsCarAvailable,
                Bookings = package.Bookings
            };
        }
    }
}
