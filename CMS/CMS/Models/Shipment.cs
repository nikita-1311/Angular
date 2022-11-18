using System;
using System.Collections.Generic;

#nullable disable

namespace CMS.Models
{
    public partial class Shipment
    {
        public int SId { get; set; }
        public string FromCity { get; set; }
        public string ToCity { get; set; }
        public decimal? Weight { get; set; }
        public DateTime? Date { get; set; }
    }
}
