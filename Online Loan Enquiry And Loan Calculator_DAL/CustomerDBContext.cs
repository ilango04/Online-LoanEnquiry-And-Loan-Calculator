using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Online_LoanEnquiry_And_Loan_Calculator_EL;

namespace Online_LoanEnquiry_And_Loan_Calculator_DAL
{
    public class CustomerDBContext:DbContext
    {
        public DbSet<Customer> customers { get; set; }
    }
}