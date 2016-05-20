using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FakeBank.Models
{
    public class PreRegistrationBindingModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string FirstLastName { get; set; }
        [Required]
        public string SecondLastName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public Guid IdAccountType { get; set; }
    }
}