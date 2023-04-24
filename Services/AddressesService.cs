using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repositories;

namespace Services
{
    public class AddressesService
    {
        private IAddressesRepository _addressesRepository;

        public AddressesService()
        {
            _addressesRepository = new AddressesRepository();
        }

        public bool Insert(Address address)
        {
            return _addressesRepository.Insert(address);
        }

        public List<Address> GetAll()
        {
            return _addressesRepository.GetAll();
        }
    }
}
