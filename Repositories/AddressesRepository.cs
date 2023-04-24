using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Models;
using static System.Formats.Asn1.AsnWriter;

namespace Repositories
{
    public class AddressesRepository : IAddressesRepository
    {
        private string Conn { get; set; }

        public AddressesRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        }
        public List<Address> GetAll()
        {
            using (var db = new SqlConnection(Conn))
            {
                var addresses = db.Query<Address>(Address.GETALL);

                return (List<Address>)addresses;
            }
        }

        public bool Insert(Address address)
        {
            var status = false;
            using (var db = new SqlConnection(Conn))
            {
                db.Open();
                db.Execute(Address.INSERT, address);
                status = true;
            }
            return status;
        }
    }
}
