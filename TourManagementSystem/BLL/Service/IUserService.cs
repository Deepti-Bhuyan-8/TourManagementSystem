using System.Collections;
using TourManagementSystem.BLL.DTOs;

namespace TourManagementSystem.BLL.Service
{
    public interface IUserService
    {
        public IEnumerable GetAllUsers();
        public UserDTO GetUserById(int id);
        public void AddUser(UserDTO user);
        public void UpdateUser(int id, UserDTO user);
        public void DeleteUser(int id);
    }
}
