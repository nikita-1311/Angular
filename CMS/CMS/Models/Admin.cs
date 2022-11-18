using System;
using System.Collections.Generic;

#nullable disable

namespace CMS.Models
{
    public partial class Admin
    {
        public int AId { get; set; }
        public string Name { get; set; }
        public long? Mobile { get; set; }
        public string Status { get; set; }
        public int? OId { get; set; }
        public string Password { get; set; }
    }
}
