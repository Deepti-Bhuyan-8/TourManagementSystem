using TourManagementSystem.DAL.Models;

namespace TourManagementSystem.DAL.Repository
{
    public interface IBookingRepo
    {
        public IEnumerable<Booking> GetAll();
        public Booking GetById(int id);
        public void Add(Booking booking);
        public void Update(Booking booking);
        public void Delete(int id);
    }
}
