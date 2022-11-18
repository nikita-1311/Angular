using System;
using System.Collections.Generic;

#nullable disable

namespace CMS.Models
{
    public partial class Comment
    {
        public int ComId { get; set; }
        public string Title { get; set; }
        public string Comment1 { get; set; }
        public DateTime? Date { get; set; }
        public int? SId { get; set; }
        public int? AId { get; set; }
    }
}
