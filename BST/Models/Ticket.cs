using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST.Models
{
    public class Ticket
    {
        public int TicketID { get; set; }

        public int UserID { get; set; }

        public int TripID { get; set; }

        public int SeatCount { get; set; }

        public decimal Price { get; set; }

        public string Status { get; set; }
    }
}
