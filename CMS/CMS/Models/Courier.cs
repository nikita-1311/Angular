using System;
using System.Collections.Generic;

#nullable disable

namespace CMS.Models
{
    public partial class Courier
    {
        public int CId { get; set; }
        public string Name { get; set; }
        public string Docket { get; set; }
        public int? SId { get; set; }
        public int? OId { get; set; }
    }
}
