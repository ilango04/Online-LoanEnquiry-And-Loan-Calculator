using System;
using System.Collections.Generic;
namespace Online_LoanEnquiry_And_Loan_Calculator_EL
{
    public enum Type
    {
        Salaried,
        SelfEmployed
    }
    public enum Bank
    {
        Axis,
        HDFC,
        KVB,
        ICICI
    }
    public class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public Type type { get; set; }
        public long monthlyIncome { get; set; }
        public long mobilenumber { get; set; }
        public string residentArea { get; set; }
        public Bank salaryReceivedIn { get; set; }
        public long desiredLoanAmount { get; set; }
        public string gender { get; set; }
        public long pincode { get; set; }
        public string panCardNumber { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string email { get; set; }
        public string company { get; set; }
        public long currentEMIAmount { get; set; }                                                                               
        public string tenure { get; set; }
        public short experience { get; set; }
        public string haveLoan { get; set; }
        public List<Customer> customers { get; set; }
    }   
}
