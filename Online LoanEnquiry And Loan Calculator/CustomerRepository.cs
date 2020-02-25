using System;
using System.Collections.Generic;
using System.Linq;
namespace Online_LoanEnquiry_And_Loan_Calculator
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
