using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repositories;

namespace Services
{
    public class ClientsService
    {
        private IClientsRepository _clientsRepository;

        public ClientsService()
        {
            _clientsRepository = new ClientsRepository();
        }

        public bool Insert(Client client)
        {
            return _clientsRepository.Insert(client);
        }

        public List<Client> GetAll()
        {
            return _clientsRepository.GetAll();
        }
    }
}
