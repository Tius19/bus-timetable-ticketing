using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST.Models
{
    public class Trip
    {
        public int TripID { get; set; }

        public int BusID { get; set; }

        public string FromLocation { get; set; }

        public string ToLocation { get; set; }

        public DateTime Departure { get; set; }

        public DateTime Arrival { get; set; }

        public string Status { get; set; }
        public decimal Price { get; set; }
        public string BusNumber { get; set; }
        public int SeatsAvailable { get; set; }
    }
}
