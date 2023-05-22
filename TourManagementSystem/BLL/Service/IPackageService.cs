using System.Collections;
using TourManagementSystem.BLL.DTOs;

namespace TourManagementSystem.BLL.Service
{
    public interface IPackageService
    {
        public IEnumerable GetAllPackages();
        public PackageDTO GetPackageById(int id);
        public void AddPackage(PackageDTO package);
        public void UpdatePackage(PackageDTO package);
        public void DeletePackage(int id);
    }
}
