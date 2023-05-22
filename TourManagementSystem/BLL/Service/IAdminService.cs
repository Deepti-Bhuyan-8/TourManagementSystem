using System.Collections;
using TourManagementSystem.BLL.DTOs;

namespace TourManagementSystem.BLL.Service
{
    public interface IAdminService
    {
        public IEnumerable GetAllAdmins();
        public AdminDTO GetAdminById(int id);
        public void AddAdmin(AdminDTO adminDto);
        public void UpdateAdmin(AdminDTO adminDto);
        public void DeleteAdmin(int id);
    }
}
