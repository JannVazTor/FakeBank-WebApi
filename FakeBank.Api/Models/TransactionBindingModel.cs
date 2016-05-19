using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FakeBank.Api.Models
{
    public class TransactionBindingModel
    {
        [Required]
        public string CardNumber { get; set; }
        [Required]
        public string ExpirationDate   { get; set; }
        [Required]
        public int SecurityCode { get; set; }
        [Required]
        public Guid Token { get; set; }
        [Required]
        public double Amount { get; set; }
    }

    public class TransferBindingModel
    {
        [Required]
        public string CardNumber { get; set; }
        [Required]
        public string IdAccount { get; set; }
        [Required]
        public double Amount { get; set; }
    }
}