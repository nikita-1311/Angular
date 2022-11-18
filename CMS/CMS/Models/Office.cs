using System;
using System.Collections.Generic;

#nullable disable

namespace CMS.Models
{
    public partial class Office
    {
        public int OId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public long? Phone { get; set; }
    }
}
