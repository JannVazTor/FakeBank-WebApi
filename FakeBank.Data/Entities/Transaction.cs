//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FakeBank.Data.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public System.Guid id { get; set; }
        public System.DateTime date { get; set; }
        public System.Guid idSourceAccount { get; set; }
        public System.Guid idDestinationAccount { get; set; }
        public double amount { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Account Account1 { get; set; }
    }
}