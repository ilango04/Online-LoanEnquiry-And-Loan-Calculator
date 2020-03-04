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
        AXIS=1,
        HDFC,
        KVB,
        ICICI
    }
    public enum Loan
    {
        YES=1,
        NO
    }
    public class CustomerModel
    {
        [Key]
        public int id { get; set; }
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
        [MaxLength(30)]
        [RegularExpression(@"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$")]
        public string tenure { get; set; }
        [Required]
        public int experience { get; set; }
        [Required]
        [EnumDataType(typeof(Loan), ErrorMessage = "Please enter the Field")]
        public Loan haveLoan { get; set; }
    }
}