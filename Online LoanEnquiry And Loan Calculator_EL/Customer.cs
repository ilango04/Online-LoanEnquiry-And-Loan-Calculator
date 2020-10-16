using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Online_LoanEnquiry_And_Loan_Calculator_EL
{
    public class Customer
    {
        [Key]
        public int customerid { get; set; }
        [Required]
        [MaxLength(30)]
        public string name { get; set; }
        [Required]
        [MaxLength(12)]
        public string type { get; set; }
        [Required]
        public int monthlyIncome { get; set; }
        [Required]
        public long mobilenumber { get; set; }
        [Required]
        [MaxLength(30)]
        public string residentArea { get; set; }
        [Required]
        [MaxLength(5)]
        public string salaryReceivedIn { get; set; }
        [Required]
        public long desiredLoanAmount { get; set; }
        [Required] 
        [MaxLength(6)]
        public string gender { get; set; }
        [Required]
        public long pincode { get; set; }
        [Required]
        [MaxLength(10)]
        public string panCardNumber { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime dateOfBirth { get; set; }
        [Required]
        [MaxLength(30)]
        public string email { get; set; }
        [Required]
        [MaxLength(20)]
        public string company { get; set; }
        public int currentEMIAmount { get; set; }
        [Required]
        public short tenure { get; set; }
        [Required]
        public int experience { get; set; }
        [Required]
        [MaxLength(3)]
        public string haveLoan { get; set; }
        [Required]
        [MaxLength(8)]
        public string password { get; set; }
        public string role { get; set; }
        public int loanid { get; set; }
        public Loan loan { get; set; }
        public int bankid { get; set; }
        public Bank Bank { get; set; }

    }
}
