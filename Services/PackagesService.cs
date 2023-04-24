using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repositories;

namespace Services
{
    public class PackagesService
    {
        private IPackagesRepository _packagesRepository;
        public PackagesService() 
        {
            _packagesRepository = new PackagesRepository();
        }

        public bool Insert (Package package)
        {
            return _packagesRepository.Insert (package);
        }

        public List<Package> GetAll () 
        {
            return _packagesRepository.GetAll ();
        }
    }
}
