using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repositories;

namespace Services
{
    public class TicketsService
    {
        private ITicketsRepository _ticketsRepository;
        public TicketsService() 
        {
            _ticketsRepository = new TicketsRepository();
        }

        public bool Insert(Ticket ticket)
        {
            return _ticketsRepository.Insert(ticket);
        }

        public List<Ticket> GetAll()
        {
            return _ticketsRepository.GetAll();
        }
    }
}
