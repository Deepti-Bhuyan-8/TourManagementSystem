using Microsoft.AspNetCore.Mvc;
using TourManagementSystem.BLL.DTOs;
using TourManagementSystem.BLL.Service;

namespace TourManagementSystem.API.Controllers
{
    [ApiController]
    [Route("api/packages")]
    public class PackageController : ControllerBase
    {
        private readonly IPackageService _packageService;

        public PackageController(IPackageService packageService)
        {
            _packageService = packageService;
        }

        [HttpGet]
        public IActionResult GetAllPackages()
        {
            var packages = _packageService.GetAllPackages();
            return Ok(packages);
        }

        [HttpGet("{id}")]
        public IActionResult GetPackageById(int id)
        {
            var package = _packageService.GetPackageById(id);
            if (package == null)
                return NotFound();

            return Ok(package);
        }

        [HttpPost]
        public IActionResult AddPackage(PackageDTO package)
        {
            _packageService.AddPackage(package);
            return CreatedAtAction(nameof(GetPackageById), new { id = package.PackageId }, package);
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePackage(int id, PackageDTO package)
        {
            _packageService.UpdatePackage(package);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePackage(int id)
        {
            _packageService.DeletePackage(id);
            return NoContent();
        }
    }
}