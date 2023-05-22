using Microsoft.EntityFrameworkCore;
using TourManagementSystem.BLL.DTOs;
using TourManagementSystem.DAL.Models;

namespace TourManagementSystem.DAL.Repository
{
    public class UserRepo : IUserRepo
    {
        private readonly AppDbContext _context;
        public UserRepo(AppDbContext context)
        {
            _context = context;
        }
        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            User user = _context.Users.Find(id);
            _context.Users.Remove(user);
            _context.SaveChanges();
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User GetById(int id)
        {
            return _context.Users.Find(id);
        }

        public void Update(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
            _context.SaveChanges();
        }

        internal void Add(UserDTO user)
        {
            throw new NotImplementedException();
        }

        internal void Update(UserDTO user)
        {
            throw new NotImplementedException();
        }
    }
}
