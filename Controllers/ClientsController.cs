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
    public class ClientsController
    {
        private ClientsService _clientsService;

        public ClientsController()
        {
            _clientsService = new ClientsService();
        }

        public bool Insert(Client client)
        {
            return _clientsService.Insert(client);
        }

        public List<Client> GetAll()
        {
            return _clientsService.GetAll();
        }
    }
}
