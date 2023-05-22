using Microsoft.EntityFrameworkCore;
using TourManagementSystem.BLL.DTOs;
using TourManagementSystem.DAL.Models;

namespace TourManagementSystem.DAL.Repository
{
    public class AdminRepo : IAdminRepo
    {
        private readonly AppDbContext _context;
        public AdminRepo(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Admin admin)
        {
            _context.Admins.Add(admin);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Admin admin = _context.Admins.Find(id);
            _context.Admins.Remove(admin);
            _context.SaveChanges();
        }

        public IEnumerable<Admin> GetAll()
        {
            return _context.Admins.ToList();
        }

        public Admin GetById(int id)
        {
            return _context.Admins.Find(id);
        }

        public void Update(Admin admin)
        {
            _context.Entry(admin).State = EntityState.Modified;
            _context.SaveChanges();
        }

        internal void Add(AdminDTO admin)
        {
            throw new NotImplementedException();
        }

        internal void Update(AdminDTO admin)
        {
            throw new NotImplementedException();
        }
    }
}
