using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MidTerm.Models
{
    public class UserContact
    {
        [Required]
        public int UserContactId { get; set; }

        public string MobileNumber { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string EmergencyContact { get; set; }

        public string Address { get; set; }
    }
}