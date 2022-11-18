using System;
using System.Collections.Generic;

#nullable disable

namespace CMS.Models
{
    public partial class Contact
    {
        public int ContactId { get; set; }
        public string CName { get; set; }
        public string Email { get; set; }
        public long? PhoneNo { get; set; }
        public string Message { get; set; }
    }
}
