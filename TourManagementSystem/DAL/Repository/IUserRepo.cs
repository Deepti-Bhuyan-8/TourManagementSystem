using TourManagementSystem.DAL.Models;

namespace TourManagementSystem.DAL.Repository
{
    public interface IUserRepo
    {
        public IEnumerable<User> GetAll();
        public User GetById(int id);
        public void Add(User user);
        public void Update(User user);
        public void Delete(int id);
    }
}
