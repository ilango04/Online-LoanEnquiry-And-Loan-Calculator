using Online_Loan_Enquiry_And_Loan_Calculator_DAL;
using Online_LoanEnquiry_And_Loan_Calculator_EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_LoanEnquiry_And_Loan_Calculator_BL
{
    public class BankBL
    {
        BankRepository repository = new BankRepository();
        public List<Bank> GetBanks()
        {
            return repository.GetBanks();
        }
        public void AddBankDetail(Bank bank)
        {
            repository.AddBank(bank);
        }
        public void EditBankDetail(Bank bank)
        {
            repository.EditBank(bank);
        }
        public void DeleteBankDetail(int bankid)
        {
            repository.DeleteBank(bankid);
        }
    }
}
