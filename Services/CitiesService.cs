using Models;
using Repositories;

namespace Services
{
    public class CitiesService
    {
        private ICitiesRepository _citiesRepository;

        public CitiesService()
        {
            _citiesRepository = new CitiesRepository();
        }

        public bool Insert(City city)
        {
            return _citiesRepository.insert(city);
        }

        public List<City> GetAll()
        {
            return _citiesRepository.GetAll();
        }
    }
}