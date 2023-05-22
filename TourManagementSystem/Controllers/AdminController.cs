using Microsoft.AspNetCore.Mvc;
using TourManagementSystem.BLL.DTOs;
using TourManagementSystem.BLL.Service;

namespace TourManagementSystem.API.Controllers
{
    [ApiController]
    [Route("api/admins")]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [HttpGet]
        public IActionResult GetAllAdmins()
        {
            var admins = _adminService.GetAllAdmins();
            return Ok(admins);
        }

        [HttpGet("{id}")]
        public IActionResult GetAdminById(int id)
        {
            var admin = _adminService.GetAdminById(id);
            if (admin == null)
                return NotFound();

            return Ok(admin);
        }

        [HttpPost]
        public IActionResult AddAdmin(AdminDTO admin)
        {
            _adminService.AddAdmin(admin);
            return CreatedAtAction(nameof(GetAdminById), new { id = admin.AdminId }, admin);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAdmin(int id, AdminDTO admin)
        {
            _adminService.UpdateAdmin(admin);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAdmin(int id)
        {
            _adminService.DeleteAdmin(id);
            return NoContent();
        }
    }
}