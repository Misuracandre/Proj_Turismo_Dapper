using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Models;

namespace Repositories
{
    public class PackagesRepository : IPackagesRepository
    {
        private string Conn { get; set; }

        public PackagesRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        }
        public List<Package> GetAll()
        {
            using (var db = new SqlConnection(Conn))
            {
                var packages = db.Query<Package>(Package.GETALL);

                return (List<Package>)packages;
            }
        }

        public bool Insert(Package package)
        {
            var status = false;
            using (var db = new SqlConnection(Conn))
            {
                db.Open();
                db.Execute(Package.INSERT, package);
                status = true;
            }
            return status;
        }
    }
}
