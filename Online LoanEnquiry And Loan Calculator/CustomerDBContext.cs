using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Online_LoanEnquiry_And_Loan_Calculator
{
    public class CustomerDBContext:DbContext
    {
        public DbSet<Customer> customers { get; set; }
    }
}