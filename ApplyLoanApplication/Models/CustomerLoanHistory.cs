//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApplyLoanApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerLoanHistory
    {
        public int SrNo { get; set; }
        public string CustomerName { get; set; }
        public string LoanDescription { get; set; }
        public string LoanType { get; set; }
        public decimal LoanRequiredAmount { get; set; }
        public decimal LoanSanctionAmount { get; set; }
        public decimal LoanStatus { get; set; }
    }
}
