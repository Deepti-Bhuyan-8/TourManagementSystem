using Microsoft.AspNetCore.Mvc;
using TourManagementSystem.BLL.DTOs;
using TourManagementSystem.BLL.Service;

namespace TourManagementSystem.API.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var users = _userService.GetAllUsers();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            var user = _userService.GetUserById(id);
            if (user == null)
                return NotFound();

            return Ok(user);
        }

        [HttpPost]
        public IActionResult AddUser(UserDTO user)
        {
            _userService.AddUser(user);
            return CreatedAtAction(nameof(GetUserById), new { id = user.UserId }, user);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, UserDTO user)
        {
            _userService.UpdateUser(id, user);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            _userService.DeleteUser(id);
            return NoContent();
        }
    }
}