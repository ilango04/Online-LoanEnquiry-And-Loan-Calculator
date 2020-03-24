using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online_LoanEnquiry_And_Loan_Calculator_DAL;
using Online_LoanEnquiry_And_Loan_Calculator_EL;

namespace Online_Loan_Enquiry_And_Loan_Calculator_DAL
{
    public class LoanRepository
    {
        public List<Loan> GetLoans()
        {
            using (CustomerDBContext context = new CustomerDBContext())
            {
                return context.loans.ToList();
            }
        }
       
        public void AddLoan(Loan loan)
        {
            using (CustomerDBContext context = new CustomerDBContext())
            {
                SqlParameter loanname = new SqlParameter("@name", loan.name);
                var data = context.Database.ExecuteSqlCommand("Loan_Insert @name", loanname);
                //context.loans.Add(loan);
                //context.SaveChanges();
            }
        }
        public void EditLoan(Loan loan)
        {
            using (CustomerDBContext context = new CustomerDBContext())
            {
                //context.Entry(loan).State = EntityState.Modified;
                SqlParameter loanid = new SqlParameter("@loanid", loan.loanid);
                SqlParameter loanname = new SqlParameter("@name", loan.name);
                var data = context.Database.ExecuteSqlCommand("Loan_Update @loanid,@name",loanid,loanname);
                //context.SaveChanges();
            }
        }
        public void DeleteLoan(int loanid)
        {
            using (CustomerDBContext context = new CustomerDBContext())
            {
                //Loan loan = context.loans.Find(loanid);
                //context.loans.Remove(loan);
                SqlParameter id = new SqlParameter("@loanid", loanid);
                var data = context.Database.ExecuteSqlCommand("Loan_Delete @loanid", id);
              //  context.SaveChanges();
            }
        }

    }
}
