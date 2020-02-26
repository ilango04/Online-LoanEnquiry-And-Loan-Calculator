using System;
using System.Collections.Generic;
using System.Linq;
using Online_LoanEnquiry_And_Loan_Calculator_EL;
namespace Online_LoanEnquiry_And_Loan_Calculator_DAL
{
    public class CustomerRepository
    {
        public List<Customer> GetCustomers()
        {
            CustomerDBContext context = new CustomerDBContext();
            return context.customers.ToList();
        }
    }
}
