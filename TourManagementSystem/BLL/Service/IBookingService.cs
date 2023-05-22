using System.Collections;
using TourManagementSystem.BLL.DTOs;

namespace TourManagementSystem.BLL.Service
{
    public interface IBookingService
    {
        public IEnumerable GetAllBookings();
        public BookingDTO GetBookingById(int id);
        public void AddBooking(BookingDTO booking);
        public void UpdateBooking(BookingDTO booking);
        public void DeleteBooking(int id);
    }
}
