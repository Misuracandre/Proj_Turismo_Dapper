using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Services;
using static System.Formats.Asn1.AsnWriter;

namespace Controllers
{
    public class PackagesController
    {
        private PackagesService _packagesService;

        public PackagesController()
        {
            _packagesService = new PackagesService();
        }

        public bool Insert(Package package)
        {
            return _packagesService.Insert(package);
        }

        public List<Package> GetAll()
        {
            return _packagesService.GetAll();
        }
    }
}
