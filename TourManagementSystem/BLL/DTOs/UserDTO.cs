using TourManagementSystem.DAL.Models;

namespace TourManagementSystem.BLL.DTOs
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public ICollection<Booking> Bookings { get; set; }

        public static explicit operator User(UserDTO dto)
        {
            if (dto == null) return null;
            return new User
            {
                UserId = dto.UserId,
                Username = dto.Username,
                Password = dto.Password
            };
        }

        public static implicit operator UserDTO(User user)
        {
            if (user == null) return null;
            return new UserDTO
            {
                UserId = user.UserId,
                Username = user.Username,
                Password = user.Password
            };
        }
    }
}
