using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online_LoanEnquiry_And_Loan_Calculator.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            IEnumerable<Customer> customer = new CustomerRepository().GetCustomers();
            return View(customer);
        }
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            if(ModelState.IsValid)
            {

            }
        }
    }
}