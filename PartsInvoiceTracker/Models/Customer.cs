using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsInvoiceTracker.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public int CustomerPhoneNumber { get; set; }
        public List<Invoice> Invoices { get; set;} = new List<Invoice>();
    }
}
