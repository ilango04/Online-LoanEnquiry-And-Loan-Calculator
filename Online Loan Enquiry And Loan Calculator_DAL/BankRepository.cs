using Online_LoanEnquiry_And_Loan_Calculator_DAL;
using Online_LoanEnquiry_And_Loan_Calculator_EL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Loan_Enquiry_And_Loan_Calculator_DAL
{
    public class BankRepository
    {
        public List<Bank> GetBanks()
        {
            using (CustomerDBContext context = new CustomerDBContext())
            {
                return context.banks.ToList();
            }
        }

        public void AddBank(Bank bank)
        {
            using (CustomerDBContext context = new CustomerDBContext())
            {
                SqlParameter bankname = new SqlParameter("@name", bank.name);
                SqlParameter interestRate = new SqlParameter("@interestRate", bank.interestRate);
                SqlParameter processingFees = new SqlParameter("@processingFees", bank.processingFees);
                SqlParameter EMI = new SqlParameter("@EMI", bank.EMI);
                SqlParameter bankTenure = new SqlParameter("@bankTenure", bank.bankTenure);
                SqlParameter minimumAmount = new SqlParameter("@minimumAmount", bank.minimumAmount);
                SqlParameter chanceOfLoan = new SqlParameter("@chanceOfLoan", bank.chanceOfLoan);
                var data = context.Database.ExecuteSqlCommand("Bank_Insert @name,@interestRate,@processingFees,@EMI,@bankTenure,@minimumAmount,@chanceOfLoan", bankname,interestRate,processingFees,EMI,bankTenure,minimumAmount,chanceOfLoan);
                //context.banks.Add(bank);
                //context.SaveChanges();
            }
        }
        public void EditBank(Bank bank)
        {
            using (CustomerDBContext context = new CustomerDBContext())
            {
                //context.Entry(bank).State = EntityState.Modified;
                SqlParameter bankid = new SqlParameter("@bankid", bank.bankid);
                SqlParameter bankname = new SqlParameter("@name", bank.name);
                SqlParameter interestRate = new SqlParameter("@interestRate", bank.interestRate);
                SqlParameter processingFees = new SqlParameter("@processingFees", bank.processingFees);
                SqlParameter EMI = new SqlParameter("@EMI", bank.EMI);
                SqlParameter bankTenure = new SqlParameter("@bankTenure", bank.bankTenure);
                SqlParameter minimumAmount = new SqlParameter("@minimumAmount", bank.minimumAmount);
                SqlParameter chanceOfLoan = new SqlParameter("@chanceOfLoan", bank.chanceOfLoan);
                var data = context.Database.ExecuteSqlCommand("Bank_Update @bankid,@name,@interestRate,@processingFees,@EMI,@bankTenure,@minimumAmount,@chanceOfLoan", bankname, interestRate, processingFees, EMI, bankTenure, minimumAmount, chanceOfLoan);
                //context.SaveChanges();
            }
        }
        public void DeleteBank(int bankid)
        {
            using (CustomerDBContext context = new CustomerDBContext())
            {
                //Bank bank = context.banks.Find(bankid);
                //context.banks.Remove(bank);
                SqlParameter id = new SqlParameter("@bankid", bankid);
                var data = context.Database.ExecuteSqlCommand("Bank_Delete @bankid", id);
                //context.SaveChanges();
            }
        }

    }
}
