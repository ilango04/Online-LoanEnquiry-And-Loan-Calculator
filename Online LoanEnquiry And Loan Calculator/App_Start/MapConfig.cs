using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Online_LoanEnquiry_And_Loan_Calculator_EL;
using Online_LoanEnquiry_And_Loan_Calculator.Models;
using Loan = Online_LoanEnquiry_And_Loan_Calculator_EL.Loan;
using Bank = Online_LoanEnquiry_And_Loan_Calculator_EL.Bank;

namespace Online_LoanEnquiry_And_Loan_Calculator.App_Start
{
    public class MapConfig
    {
        public static void Mapper()
        {
            AutoMapper.Mapper.Initialize(config =>
            {
                config.CreateMap<CustomerModel,Customer>();
                config.CreateMap<Loan, LoanModel>();
                config.CreateMap<Customer, CustomerModel>();
                config.CreateMap<BankModel,Bank>();
                config.CreateMap<Bank, BankModel>();
            }); 
        }
    }
}