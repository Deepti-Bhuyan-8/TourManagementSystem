using System.Collections;
using TourManagementSystem.BLL.DTOs;
using TourManagementSystem.DAL.Models;
using TourManagementSystem.DAL.Repository;

namespace TourManagementSystem.BLL.Service
{
    public class AdminService : IAdminService
    {
        private readonly AdminRepo _adminRepository;

        public AdminService(AdminRepo adminRepository)
        {
            _adminRepository = adminRepository;
        }
        public void AddAdmin(AdminDTO admin)
        {
            _adminRepository.Add(admin);
        }

        public void DeleteAdmin(int id)
        {
            _adminRepository.Delete(id);
        }

        public AdminDTO GetAdminById(int id)
        {
            return _adminRepository.GetById(id);
        }

        public IEnumerable GetAllAdmins()
        {
            return _adminRepository.GetAll();
        }

        public void UpdateAdmin(AdminDTO admin)
        {
            _adminRepository.Update(admin);
        }
    }
}
