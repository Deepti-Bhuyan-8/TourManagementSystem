using Microsoft.AspNetCore.Mvc;
using TourManagementSystem.BLL.DTOs;
using TourManagementSystem.BLL.Service;

namespace TourManagementSystem.API.Controllers
{
    [ApiController]
    [Route("api/bookings")]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult GetAllBookings()
        {
            var bookings = _bookingService.GetAllBookings();
            return Ok(bookings);
        }

        [HttpGet("{id}")]
        public IActionResult GetBookingById(int id)
        {
            var booking = _bookingService.GetBookingById(id);
            if (booking == null)
                return NotFound();

            return Ok(booking);
        }

        [HttpPost]
        public IActionResult AddBooking(BookingDTO booking)
        {
            _bookingService.AddBooking(booking);
            return CreatedAtAction(nameof(GetBookingById), new { id = booking.BookingId }, booking);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBooking(int id, BookingDTO booking)
        {
            _bookingService.UpdateBooking(booking);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            _bookingService.DeleteBooking(id);
            return NoContent();
        }
    }
}