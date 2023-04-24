using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Address
    {
        public readonly static string INSERT = "INSERT INTO Address (Street, Number, Neighborhood, ZipCode, Extension, IdCity)" + 
                                               "VALUES (@Street, @Number, @Neighborhood, @ZipCode, @Extension, @IdCity)";

        public readonly static string GETALL = "SELECT a.Id, a.Street, a.Number, a.Neighborhood, a.ZipCode, a.Extension, c.Id, c.Description" +
                                               " FROM Address a," +
                                               " JOIN City c ON a.IdCity = c.Id";
        public int Id { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string Neighborhood { get; set; }
        public string ZipCode { get; set; }
        public string Extension { get; set; }
        public City IdCity { get; set; }
        public DateTime Registration_Date { get; set; }
    }
}
