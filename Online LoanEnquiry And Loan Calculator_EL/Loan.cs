using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_LoanEnquiry_And_Loan_Calculator_EL
{
    public class Loan
    {
        [Key]
        public int loanid { get; set; }
        [Required]
        [MaxLength(30)]
        public string name { get; set; }
    }
}
