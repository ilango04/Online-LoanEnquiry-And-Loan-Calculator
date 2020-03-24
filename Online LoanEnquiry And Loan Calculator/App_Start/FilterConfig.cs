using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Online_LoanEnquiry_And_Loan_Calculator.App_Start
{
    public class FilterConfig
    {
        public static void GlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}