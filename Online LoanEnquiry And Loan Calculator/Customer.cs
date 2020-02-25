using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Online_LoanEnquiry_And_Loan_Calculator
{
    public class Customer
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public long monthlyIncome { get; set; }
        public long mobilenumber { get; set; }
        public string residentArea { get; set; }
        public string salaryReceivedIn { get; set; }
        public long desiredLoanAmount { get; set; }
        public string gender { get; set; }
        public long pincode { get; set; }
        public string panCardNumber { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string email { get; set; }
        public string company { get; set; }
        public long currentEMIAmount { get; set; }                                                                               
        public string tenure { get; set; }
        public short experience { get; set; }
        public string haveLoan { get; set; }
        public List<Customer> customers { get; set; }
    }   
}
