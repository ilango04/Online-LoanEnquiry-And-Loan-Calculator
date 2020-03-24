using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_LoanEnquiry_And_Loan_Calculator_EL
{
    public class Bank
    {
        [Key]
        public int bankid { get; set; } 
        [Required]
        [MaxLength(30)]
        public string name { get; set; }
        [Required]
        public short interestRate { get; set; }
        [Required]
        public int processingFees { get; set; }
        [Required]
        public int EMI { get; set; }
        [Required]
        public int bankTenure { get; set; }
        [Required]
        public int minimumAmount { get; set; }
        public int loanid { get; set; }
        public Loan Loan { get; set; }
        [Required]
        public string chanceOfLoan { get; set; }
     
    }
}
