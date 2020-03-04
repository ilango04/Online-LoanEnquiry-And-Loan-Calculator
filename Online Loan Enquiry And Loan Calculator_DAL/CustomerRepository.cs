using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Online_LoanEnquiry_And_Loan_Calculator_EL;
namespace Online_LoanEnquiry_And_Loan_Calculator_DAL
{
    public class CustomerRepository
    {
        CustomerDBContext context = new CustomerDBContext();
        public List<Customer> GetCustomers()
        {
            return context.customers.ToList();
        }
        public void AddCustomer(Customer customer)
        {
            context.customers.Add(customer);
            context.SaveChanges();
        }
        public void EditCustomer(Customer customer)
        {
            context.Entry(customer).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteCustomer(int id)
        {
            Customer customer = context.customers.Find(id);
            context.customers.Remove(customer);
            context.SaveChanges();
        }
    }
}
