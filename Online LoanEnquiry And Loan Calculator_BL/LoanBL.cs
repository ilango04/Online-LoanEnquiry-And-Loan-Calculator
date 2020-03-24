using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online_Loan_Enquiry_And_Loan_Calculator_DAL;
using Online_LoanEnquiry_And_Loan_Calculator_EL;

namespace Online_LoanEnquiry_And_Loan_Calculator_BL
{
    public class LoanBL
    {
        LoanRepository repository=new LoanRepository();
        public List<Loan> GetLoans()
        {
            return repository.GetLoans();
        }
        public void AddLoanDetail(Loan loan)
        {
            repository.AddLoan(loan);
        }
        public void EditLoanDetail(Loan loan)
        {
            repository.EditLoan(loan);
        }
        public void DeleteLoanDetail(int loanid)
        {
            repository.DeleteLoan(loanid);
        }
    }

}
