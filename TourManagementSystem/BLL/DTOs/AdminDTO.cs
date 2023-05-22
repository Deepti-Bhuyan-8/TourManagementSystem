using TourManagementSystem.DAL.Models;

namespace TourManagementSystem.BLL.DTOs
{
    public class AdminDTO
    {
        public int AdminId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public static explicit operator Admin(AdminDTO dto)
        {
            if (dto == null) return null;
            return new Admin
            {
                AdminId = dto.AdminId,
                Username = dto.Username,
                Password = dto.Password
            };
        }

        public static implicit operator AdminDTO(Admin admin)
        {
            if (admin == null) return null;
            return new AdminDTO
            {
                AdminId = admin.AdminId,
                Username = admin.Username,
                Password = admin.Password
            };
        }
    }
}
