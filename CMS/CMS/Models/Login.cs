using System;
using System.Collections.Generic;

#nullable disable

namespace CMS.Models
{
    public partial class Login
    {
        public int LId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public int? AId { get; set; }
    }
}
