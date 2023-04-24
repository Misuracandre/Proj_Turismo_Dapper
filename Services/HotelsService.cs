using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repositories;

namespace Services
{
    public class HotelsService
    {
        private IHotelsRepository _repository;
        public HotelsService() 
        {
            _repository = new HotelsRepository();
        }

        public bool Insert(Hotel hotel)
        {
            return _repository.Insert(hotel);
        }

        public List<Hotel> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
