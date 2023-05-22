using Microsoft.EntityFrameworkCore;
using TourManagementSystem.BLL.DTOs;
using TourManagementSystem.DAL.Models;

namespace TourManagementSystem.DAL.Repository
{
    public class BookingRepo : IBookingRepo
    {
        private readonly AppDbContext _context;
        public BookingRepo(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Booking booking)
        {
            _context.Bookings.Add(booking);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Booking booking = _context.Bookings.Find(id);
            _context.Bookings.Remove(booking);
            _context.SaveChanges();
        }

        public IEnumerable<Booking> GetAll()
        {
            return _context.Bookings.ToList();
        }

        public Booking GetById(int id)
        {
            return _context.Bookings.Find(id);
        }

        public void Update(Booking booking)
        {
            _context.Entry(booking).State = EntityState.Modified;
            _context.SaveChanges();
        }

        internal void Add(BookingDTO booking)
        {
            throw new NotImplementedException();
        }

        internal void Update(BookingDTO booking)
        {
            throw new NotImplementedException();
        }
    }
}
