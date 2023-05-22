using Microsoft.EntityFrameworkCore;
using TourManagementSystem.BLL.DTOs;
using TourManagementSystem.DAL.Models;

namespace TourManagementSystem.DAL.Repository
{
    public class PackageRepo : IPackageRepo
    {
        private readonly AppDbContext _context;
        public PackageRepo(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Package package)
        {
            _context.Packages.Add(package);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Package package = _context.Packages.Find(id);
            _context.Packages.Remove(package);
            _context.SaveChanges();
        }

        public IEnumerable<Package> GetAll()
        {
            return _context.Packages.ToList();
        }

        public Package GetById(int id)
        {
            return _context.Packages.Find(id);
        }

        public void Update(Package package)
        {
            _context.Entry(package).State = EntityState.Modified;
            _context.SaveChanges();
        }

        internal void Add(PackageDTO package)
        {
            throw new NotImplementedException();
        }

        internal void Update(PackageDTO package)
        {
            throw new NotImplementedException();
        }
    }
}
