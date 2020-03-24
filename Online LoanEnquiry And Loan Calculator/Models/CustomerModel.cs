using Online_LoanEnquiry_And_Loan_Calculator_EL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Online_LoanEnquiry_And_Loan_Calculator.Models
{
    public enum Type
    {
        Salaried=1,
        SelfEmployed
    }
    public enum Bank
    {
        Cheque=1,
        Cash,
        AXIS,
        HDFC,
        KVB,
        ICICI,
        LVB,
        SBI,
        IDFC,
        YES,
        KOTAK,
        CUB,
        TMB,
    }
    public enum Loans
    {
        YES=1,
        NO
    }
    public enum Role
    {
        User,
        Admin
    }
    public class CustomerModel
    {
        [Key]
        public int customerid { get; set; }
        [Required]
        [MaxLength(30)]
        [RegularExpression(@"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$")]
        public string name { get; set; }
        [Required]
        [EnumDataType(typeof(Type), ErrorMessage = "Please enter the type")]
        public Type type { get; set; }
        [Required]
        public int monthlyIncome { get; set; }
        [Required]
        [RegularExpression(@"^\+?([0-9]{2})\)?[-. ]?([0-9]{4})[-. ]?([0-9]{4})$")]
        public long mobilenumber { get; set; }
        [Required]
        [MaxLength(30)]
        [RegularExpression(@"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$")]
        public string residentArea { get; set; }
        [Required]
        [EnumDataType(typeof(Bank),ErrorMessage ="Please enter the Bank")]
        public Bank salaryReceivedIn { get; set; }
        [Required]
        public long desiredLoanAmount { get; set; }
        [Required]
        [MaxLength(6)]
        public string gender { get; set; }
        [Required]
        [RegularExpression(@"^(?!0+$)[0-9]{6,6}$")]
        public long pincode { get; set; }
        [Required]
        [RegularExpression(@"([A-Z]){5}([0-9]){4}([A-Z]){1}$")]
        public string panCardNumber { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime dateOfBirth { get; set; }
        [Required]
        [MaxLength(30)]
        [RegularExpression(@"^[^\s@]+@[^\s@]+\.[^\s@]+$")]
        public string email { get; set; }
        [Required]
        [MaxLength(20)]
        [RegularExpression(@"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$")]
        public string company { get; set; }
        public int currentEMIAmount { get; set; }
        [Required]
        public short tenure { get; set; }
        [Required]
        public int experience { get; set; }
        [Required]
        [EnumDataType(typeof(Loans), ErrorMessage = "Please enter the Field")]
        public Loans haveLoan { get; set; }
        [Required]
        [MaxLength(8)]
        public string password { get; set; }
        public Role role { get; set; }
        public Loan loan { get; set; }
    }
}