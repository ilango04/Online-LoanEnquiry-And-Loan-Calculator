using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online_LoanEnquiry_And_Loan_Calculator.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index()
        {
            throw new Exception("Some unknown error encountered!");
        }
    }
}