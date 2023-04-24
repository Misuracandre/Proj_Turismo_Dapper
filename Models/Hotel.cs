using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Hotel
    {
        public readonly static string INSERT = "INSERT INTO Hotel (Name, IdAddress, Value)" + 
                                               "VALUES (@Name, @IdAddress, @Value)";

        public readonly static string GETALL = "SELECT h.Id, h.Name, h.Value, a.Street, a.Number, a.Neighborhood, a.ZipCode, a.Extension, c.Id, c.Description" +
                                               "FROM Hotel h," +
                                               "JOIN Address a ON h.IdAddress = a.Id" +
                                               "JOIN City c ON a.IdCity = c.Id";
        public int Id { get; set; }
        public string Name { get; set; }
        public Address IdAddress { get; set; }
        public decimal Value { get; set; }
        public DateTime Registration_Date { get; set; }
    }
}
