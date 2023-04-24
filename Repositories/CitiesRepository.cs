using System.Configuration;
using Models;
using Dapper;
using System.Data.SqlClient;

namespace Repositories
{
    public class CitiesRepository : ICitiesRepository
    {
        private string Conn { get; set; }

        public CitiesRepository() 
        {
            Conn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        }
        public bool insert(City city)
        {
            var status = false;
            using (var db = new SqlConnection(Conn))
            {
                db.Open();
                db.Execute(City.INSERT, city);
                status = true;
            }
            return status;
        }
        public List<City> GetAll()
        {
            using (var db = new SqlConnection(Conn))
            {
                var cities = db.Query<City>(City.GETALL);

                return (List<City>)cities;
            }
        }

    }
}