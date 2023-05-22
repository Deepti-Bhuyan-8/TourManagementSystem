using TourManagementSystem.DAL.Models;

namespace TourManagementSystem.DAL.Repository
{
    public interface IAdminRepo
    {
        public IEnumerable<Admin> GetAll();
        public Admin GetById(int id);
        public void Add(Admin admin);
        public void Update(Admin admin);
        public void Delete(int id);
    }
}
