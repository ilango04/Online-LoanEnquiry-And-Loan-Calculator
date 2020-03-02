using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Online_LoanEnquiry_And_Loan_Calculator.Models
{
    public enum Type
    {
        Salaried,
        SelfEmployed
    }
    public enum Bank
    {
        Axis,
        HDFC,
        KVB,
        ICICI
    }
    public enum Loan
    {
        YES,
        NO
    }
    public class CustomerModel
    {
        [Key]
        public int id { get; set; }
        [Required]
        [MaxLength(30)]
        public string name { get; set; }
        [Required]
        public Type type { get; set; }
        [Required]
        [MaxLength(7)]
        public long monthlyIncome { get; set; }
        [Required]
        [MaxLength(10)]
        public long mobilenumber { get; set; }
        [Required]
        [MaxLength(30)]
        public string residentArea { get; set; }
        [Required]
        public Bank salaryReceivedIn { get; set; }
        [Required]
        [MaxLength(6)]
        public long desiredLoanAmount { get; set; }
        [Required]
        public string gender { get; set; }
        [Required]
        [MaxLength(6)]
        public long pincode { get; set; }
        [Required]
        [MaxLength(10)]
        public string panCardNumber { get; set; }
        [Required]
        public DateTime dateOfBirth { get; set; }
        [Required]
        [MaxLength(30)]
        public string email { get; set; }
        [Required]
        [MaxLength(20)]
        public string company { get; set; }
        public long currentEMIAmount { get; set; }
        [Required]
        [MaxLength(30)]
        public string tenure { get; set; }
        [Required]
        [MaxLength(2)]
        public short experience { get; set; }
        [Required]
        public Loan haveLoan { get; set; }
    }
}