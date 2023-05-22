using TourManagementSystem.DAL.Models;

namespace TourManagementSystem.BLL.DTOs
{
    public class BookingDTO
    {
        public int BookingId { get; set; }
        public int UserId { get; set; }
        public int PackageId { get; set; }
        public DateTime BookingDate { get; set; }
        public int NumOfTickets { get; set; }
        public Package Package { get; set; }
        public User User { get; set; }

        public static explicit operator Booking(BookingDTO dto)
        {
            if (dto == null) return null;
            return new Booking
            {
                BookingId = dto.BookingId,
                UserId = dto.UserId,
                PackageId = dto.PackageId,
                BookingDate = dto.BookingDate,
                NumOfTickets = dto.NumOfTickets,
                Package = dto.Package,
                User = dto.User
            };
        }

        public static implicit operator BookingDTO(Booking booking)
        {
            if (booking == null) return null;
            return new BookingDTO
            {
                BookingId = booking.BookingId,
                UserId = booking.UserId,
                PackageId = booking.PackageId,
                BookingDate = booking.BookingDate,
                NumOfTickets = booking.NumOfTickets,
                Package = booking.Package,
                User = booking.User
            };
        }
    }
}
