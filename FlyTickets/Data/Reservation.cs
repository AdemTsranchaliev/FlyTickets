using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyTickets.Data
{
    public class Reservation
    {
        public Guid Id { get; set; }
        public int RouteId { get; set; }

        public string Name { get; set; }

        public int Laguage { get; set; }
    }
}
