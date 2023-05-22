using TourManagementSystem.DAL.Models;

namespace TourManagementSystem.DAL.Repository
{
    public interface IPackageRepo
    {
        public IEnumerable<Package> GetAll();
        public Package GetById(int id);
        public void Add(Package package);
        public void Update(Package package);
        public void Delete(int id);
    }
}
