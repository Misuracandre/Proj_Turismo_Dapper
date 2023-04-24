using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Client
    {
        public readonly static string INSERT = "INSERT INTO Client (Name, Phone, IdAddress)" + 
                                               "VALUES (@Name, @Phone, @IdAddress)";

        public readonly static string GETALL = "SELECT c.Id, c.Name, c.Phone, a.Street, a.Number, a.Neighborhood, a.ZipCode, a.Extension, s.Id, s.Description" +
                                               " FROM Client c," +
                                               " JOIN Address a ON c.IdAddress = a.Id" +
                                               " JOIN City s ON a.IdCity = s.Id";
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public Address IdAddress { get; set; }
        public DateTime Registration_Date { get; set; }
    }
}
