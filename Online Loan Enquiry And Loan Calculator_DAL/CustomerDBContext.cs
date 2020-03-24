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
        public DbSet<Loan> loans { get; set; }
        public DbSet<Bank> banks { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().MapToStoredProcedures();
            modelBuilder.Entity<Loan>().MapToStoredProcedures();
            modelBuilder.Entity<Bank>().MapToStoredProcedures();
        }
    }
}