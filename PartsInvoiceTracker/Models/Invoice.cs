using Microsoft.IdentityModel.Abstractions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsInvoiceTracker.Entities
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public int EmployeeId { get; set; }
        public Customer Customer { get; set; } = null!;
        public string CustomerId { get; set; } = null!;
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerPhoneNumber { get; set; } =string.Empty;
        public string PartsDesc { get; set; } = string.Empty;
        public bool Prepaid { get; set; }
       
        
    }
}
