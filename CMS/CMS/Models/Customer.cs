using System;
using System.Collections.Generic;

#nullable disable

namespace CMS.Models
{
    public partial class Customer
    {
        public int CustId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long? Mobile { get; set; }
        public int? OId { get; set; }
        public int? SId { get; set; }
    }
}
