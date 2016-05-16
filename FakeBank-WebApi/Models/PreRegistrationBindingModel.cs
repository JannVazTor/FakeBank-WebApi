using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FakeBank_WebApi.Models
{
    public class PreRegistrationBindingModel
    {
        [Required]
        public System.Guid id { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string firstLastName { get; set; }
        [Required]
        public string secondLastName { get; set; }
        [Required]
        public string phoneNumber { get; set; }
        [Required]
        public string email { get; set; }
    }
}