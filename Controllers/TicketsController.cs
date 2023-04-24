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
    public class TicketsController
    {
        private TicketsService _ticketsService;

        public TicketsController()
        {
            _ticketsService = new TicketsService();
        }

        public bool Insert(Ticket ticket)
        {
            return _ticketsService.Insert(ticket);
        }

        public List<Ticket> GetAll()
        {
            return _ticketsService.GetAll();
        }
    }
}
