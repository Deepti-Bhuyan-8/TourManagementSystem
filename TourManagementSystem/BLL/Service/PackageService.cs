using System.Collections;
using TourManagementSystem.BLL.DTOs;
using TourManagementSystem.DAL.Models;
using TourManagementSystem.DAL.Repository;

namespace TourManagementSystem.BLL.Service
{
    public class PackageService : IPackageService
    {
        private readonly PackageRepo _packageRepository;

        public PackageService(PackageRepo packageRepository)
        {
            _packageRepository = packageRepository;
        }
        public void AddPackage(PackageDTO package)
        {
            _packageRepository.Add(package);
        }

        public void DeletePackage(int id)
        {
            _packageRepository.Delete(id);
        }

        public IEnumerable GetAllPackages()
        {
            return _packageRepository.GetAll();
        }

        public PackageDTO GetPackageById(int id)
        {
            return _packageRepository.GetById(id);
        }

        public void UpdatePackage(PackageDTO package)
        {
            _packageRepository.Update(package);
        }
    }
}
