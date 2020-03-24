using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online_LoanEnquiry_And_Loan_Calculator_DAL;
using Online_LoanEnquiry_And_Loan_Calculator_EL;

namespace Online_LoanEnquiry_And_Loan_Calculator_BL
{
    public class CustomerBL
    {
        CustomerRepository repository = new CustomerRepository();
        
        public List<Customer> GetCustomers()
        {
            return repository.GetCustomers();
        }
        public void AddCustomerDetail(Customer customer)
        {
            repository.AddCustomer(customer);
        }
        public void EditCustomerDetail(Customer customer)
        {
            repository.EditCustomer(customer);
        }
        public void DeleteCustomerDetail(int id)
        {
            repository.DeleteCustomer(id);
        }
    }
}
