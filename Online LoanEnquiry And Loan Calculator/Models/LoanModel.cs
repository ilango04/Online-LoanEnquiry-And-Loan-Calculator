using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Online_LoanEnquiry_And_Loan_Calculator.Models
{
    public class LoanModel
    {
        [Key]
        public int loanid { get; set; }
        [Required]
        [MaxLength(30)]
        [RegularExpression(@"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$")]
        public string name { get; set; }
    }
}