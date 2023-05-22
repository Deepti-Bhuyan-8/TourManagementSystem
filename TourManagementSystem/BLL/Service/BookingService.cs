using System.Collections;
using TourManagementSystem.BLL.DTOs;
using TourManagementSystem.DAL.Models;
using TourManagementSystem.DAL.Repository;

namespace TourManagementSystem.BLL.Service
{
    public class BookingService : IBookingService
    {
        private readonly BookingRepo _bookingRepository;

        public BookingService(BookingRepo bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }
        public void AddBooking(BookingDTO booking)
        {
            _bookingRepository.Add(booking);
        }

        public void DeleteBooking(int id)
        {
            _bookingRepository.Delete(id);
        }

        public IEnumerable GetAllBookings()
        {
            return _bookingRepository.GetAll();
        }

        public BookingDTO GetBookingById(int id)
        {
            return _bookingRepository.GetById(id);
        }

        public void UpdateBooking(BookingDTO booking)
        {
            _bookingRepository.Update(booking);
        }
    }
}
