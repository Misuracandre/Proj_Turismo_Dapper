using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Services;

namespace Controllers
{
    public class AddressesController
    {
        private AddressesService _addressesService;

        public AddressesController()
        {
            _addressesService = new AddressesService();
        }

        public bool Insert(Address address)
        {
            return _addressesService.Insert(address);
        }

        public List<Address> GetAddresses() 
        {
            return _addressesService.GetAll();
        }
    }
}
