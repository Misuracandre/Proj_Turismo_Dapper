using Models;
using Services;

namespace Controllers
{
    public class CitiesController
    {
        private CitiesService _citiesService;

        public CitiesController()
        {
            _citiesService = new CitiesService();
        }

        public bool Insert(City city)
        {
            return _citiesService.Insert(city);
        }

        public List<City> GetAll()
        {
            return _citiesService.GetAll();
        }
    }
}