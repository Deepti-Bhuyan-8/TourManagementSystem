using System.Collections;
using TourManagementSystem.BLL.DTOs;
using TourManagementSystem.DAL.Models;
using TourManagementSystem.DAL.Repository;

namespace TourManagementSystem.BLL.Service
{
    public class UserService : IUserService
    {
        private readonly UserRepo _userRepository;

        public UserService(UserRepo userRepository)
        {
            _userRepository = userRepository;
        }

        public void AddUser(UserDTO user)
        {
            _userRepository.Add(user);
        }

        public void DeleteUser(int id)
        {
            _userRepository.Delete(id);
        }

        public IEnumerable GetAllUsers()
        {
            return _userRepository.GetAll();
        }

        public UserDTO GetUserById(int id)
        {
            return _userRepository.GetById(id);
        }

        public void UpdateUser(int id, UserDTO user)
        {
            _userRepository.Update(user);
        }
    }
}
