using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using Online_LoanEnquiry_And_Loan_Calculator_EL;
namespace Online_LoanEnquiry_And_Loan_Calculator_DAL
{
    public class CustomerRepository
    {
        public List<Customer> GetCustomers()
        {
            using (CustomerDBContext context = new CustomerDBContext())
            {
                return context.customers.ToList();
            }
        }
        public void AddCustomer(Customer customer)
        {
            using (CustomerDBContext context = new CustomerDBContext())
            {
                //context.customers.Add(customer);
                SqlParameter name = new SqlParameter("@name", customer.name);
                SqlParameter type = new SqlParameter("@type", customer.type);
                SqlParameter monthlyIncome = new SqlParameter("@monthlyIncome", customer.monthlyIncome);
                SqlParameter mobilenumber = new SqlParameter("@mobilenumber", customer.mobilenumber);
                SqlParameter residentArea = new SqlParameter("@residentArea", customer.residentArea);
                SqlParameter salaryReceivedIn = new SqlParameter("@salaryReceivedIn", customer.salaryReceivedIn);
                SqlParameter desiredLoanAmount = new SqlParameter("@desiredLoanAmount", customer.desiredLoanAmount);
                SqlParameter gender = new SqlParameter("@gender", customer.gender);
                SqlParameter pincode = new SqlParameter("@pincode", customer.pincode);
                SqlParameter panCardNumber = new SqlParameter("@panCardNumber", customer.panCardNumber);
                SqlParameter dateOfBirth = new SqlParameter("@dateOfBirth", customer.dateOfBirth);
                SqlParameter email = new SqlParameter("@email", customer.email);
                SqlParameter company = new SqlParameter("@company", customer.company);
                SqlParameter currentEMIAmount = new SqlParameter("@currentEMIAmount", customer.currentEMIAmount);
                SqlParameter tenure = new SqlParameter("@tenure", customer.tenure);
                SqlParameter experience = new SqlParameter("@experience", customer.experience);
                SqlParameter haveLoan = new SqlParameter("@haveLoan", customer.haveLoan);
                SqlParameter password = new SqlParameter("@password", customer.password);
                SqlParameter role = new SqlParameter("@role", customer.role);
                var data = context.Database.ExecuteSqlCommand("Customer_Insert @name,@type,@monthlyIncome,@mobilenumber,@residentArea,@salaryReceivedIn,@desiredLoanAmount,@gender,@pincode,@panCardNumber,@dateOfBirth,@email,@company,@currentEMIAmount,@tenure,@experience,@haveLoan,@password,@role", name,type,monthlyIncome,mobilenumber,residentArea,salaryReceivedIn,desiredLoanAmount,gender,pincode,panCardNumber,dateOfBirth,email,company,currentEMIAmount,tenure,experience,haveLoan, password,role);
                //context.SaveChanges();
            }
        }
        public void EditCustomer(Customer customer)
        {
            using (CustomerDBContext context = new CustomerDBContext())
            {
                //context.Entry(customer).State = EntityState.Modified;
                SqlParameter residentArea = new SqlParameter("@residentArea", customer.residentArea);
                SqlParameter email = new SqlParameter("@email", customer.email);
                SqlParameter currentEMIAmount = new SqlParameter("@currentEMIAmount", customer.currentEMIAmount);
                SqlParameter tenure = new SqlParameter("@tenure", customer.tenure);
                SqlParameter password = new SqlParameter("@password", customer.password);
                var data = context.Database.ExecuteSqlCommand("Customer_Update @residentArea,@email,@currentEMIAmount,@tenure,,@password",  residentArea,email, currentEMIAmount, tenure, password);
                //context.SaveChanges();
            }
        }
        public void DeleteCustomer(int customerid)
        {
            using (CustomerDBContext context = new CustomerDBContext())
            {
                SqlParameter id = new SqlParameter("@customerid", customerid);
                var data = context.Database.ExecuteSqlCommand("Customer_Delete @customerid", id);
                //Customer customer = context.customers.Find(id);
                //context.customers.Remove(customer);
                //context.SaveChanges();
            }
        }
        public static Customer CheckLogin(Customer customer)
        {
            using (CustomerDBContext context = new CustomerDBContext())
            {
                return context.customers.Where(data => data.mobilenumber == customer.mobilenumber && data.password == customer.password).SingleOrDefault();
            }
        }
        public static Customer CheckUser()
        {
            using (CustomerDBContext context = new CustomerDBContext())
            {
                return context.customers.Where(data=>data.role!="Admin").SingleOrDefault();
            }
        }
    }
}
