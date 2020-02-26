using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Online_LoanEnquiry_And_Loan_Calculator_DAL;
using Online_LoanEnquiry_And_Loan_Calculator_EL;
using System.Web.Mvc;

namespace Online_LoanEnquiry_And_Loan_Calculator.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            new CustomerRepository().GetCustomers();
            return View();
        }
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(Customer customer)
        {
            if(ModelState.IsValid)
            {
                CustomerRepository repository = new CustomerRepository();
                repository.GetCustomers();
                repository.AddCustomer(customer);
                return View();
            }
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
    }
}