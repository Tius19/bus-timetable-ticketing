using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST.Models
{
    public class Payment
    {
        public int PaymentID { get; set; }

        public int UserID { get; set; }

        public int TripID { get; set; }

        public decimal Amount { get; set; }

        public string Status { get; set; }
    }
}
