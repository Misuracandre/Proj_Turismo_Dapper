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
    public class HotelsController
    {
        private HotelsService _hotelsService;

        public HotelsController()
        {
            _hotelsService = new HotelsService();
        }

        public bool Insert(Hotel hotel)
        {
            return _hotelsService.Insert(hotel);
        }

        public List<Hotel> GetAll()
        {
            return _hotelsService.GetAll();
        }
    }
}
