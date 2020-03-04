using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Online_LoanEnquiry_And_Loan_Calculator_DAL;
using Online_LoanEnquiry_And_Loan_Calculator_EL;
using System.Web.Mvc;
using Online_LoanEnquiry_And_Loan_Calculator.Models;
using System.Net;
using System.Data.Entity;
using Type = Online_LoanEnquiry_And_Loan_Calculator.Models.Type;

namespace Online_LoanEnquiry_And_Loan_Calculator.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult Index()
        {
            IEnumerable<Customer> customerDetails = new CustomerRepository().GetCustomers();
            return View(customerDetails);
        }
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(CustomerModel model)
        {
            if (ModelState.IsValid)
            {
                CustomerRepository repository = new CustomerRepository();
                Customer customer = new Customer
                {
                    id = model.id,
                    name = model.name,
                    type = Convert.ToString(model.type),
                    monthlyIncome = model.monthlyIncome,
                    mobilenumber = model.mobilenumber,
                    residentArea = model.residentArea,
                    salaryReceivedIn = Convert.ToString(model.salaryReceivedIn),
                    desiredLoanAmount = model.desiredLoanAmount,
                    gender = model.gender,
                    pincode = model.pincode,
                    panCardNumber = model.panCardNumber,
                    dateOfBirth = model.dateOfBirth,
                    email = model.email,
                    company = model.company,
                    currentEMIAmount = model.currentEMIAmount,
                    tenure = model.tenure,
                    experience = model.experience,
                    haveLoan = Convert.ToString(model.haveLoan)
                };
                repository.AddCustomer(customer);
                ViewBag.Status = "Registration Successful";
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit(int id)
        {
            CustomerDBContext context = new CustomerDBContext();
            Customer customerDetail = context.customers.Find(id);
            CustomerModel model = new CustomerModel
            {
                id = customerDetail.id,
                name = customerDetail.name,
                type = (Type)Enum.Parse(typeof(Type), (customerDetail.type)),
                monthlyIncome = customerDetail.monthlyIncome,
                mobilenumber = customerDetail.mobilenumber,
                residentArea = customerDetail.residentArea,
                salaryReceivedIn = (Bank)Enum.Parse(typeof(Bank), (customerDetail.salaryReceivedIn)),
                desiredLoanAmount = customerDetail.desiredLoanAmount,
                gender = customerDetail.gender,
                pincode = customerDetail.pincode,
                panCardNumber = customerDetail.panCardNumber,
                dateOfBirth = customerDetail.dateOfBirth,
                email = customerDetail.email,
                company = customerDetail.company,
                currentEMIAmount = customerDetail.currentEMIAmount,
                tenure = customerDetail.tenure,
                experience = customerDetail.experience,
                haveLoan = (Loan)Enum.Parse(typeof(Loan), (customerDetail.haveLoan))
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit([Bind(Include = "id,name,type,monthlyIncome,mobilenumber,residentArea,salaryReceivedIn,desiredLoanAmount,gender,pincode,panCardNumber,dateOfBirth,email,company,currentEMIAmount,tenure,experience,haveLoan")]CustomerModel model)
        {
            if (ModelState.IsValid)
            {
                Customer customer = new Customer
                {
                    id = model.id,
                    name = model.name,
                    type = Convert.ToString(model.type),
                    monthlyIncome = model.monthlyIncome,
                    mobilenumber = model.mobilenumber,
                    residentArea = model.residentArea,
                    salaryReceivedIn = Convert.ToString(model.salaryReceivedIn),
                    desiredLoanAmount = model.desiredLoanAmount,
                    gender = model.gender,
                    pincode = model.pincode,
                    panCardNumber = model.panCardNumber,
                    dateOfBirth = model.dateOfBirth,
                    email = model.email,
                    company = model.company,
                    currentEMIAmount = model.currentEMIAmount,
                    tenure = model.tenure,
                    experience = model.experience,
                    haveLoan = Convert.ToString(model.haveLoan)
                };
                new CustomerRepository().EditCustomer(customer);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public ActionResult Delete(int id)
        {
            CustomerDBContext context = new CustomerDBContext();
            Customer customerDetail = context.customers.Find(id);
            CustomerModel model = new CustomerModel
            {
                id = customerDetail.id,
                name = customerDetail.name,
                type = (Type)Enum.Parse(typeof(Type), (customerDetail.type)),
                monthlyIncome = customerDetail.monthlyIncome,
                mobilenumber = customerDetail.mobilenumber,
                residentArea = customerDetail.residentArea,
                salaryReceivedIn = (Bank)Enum.Parse(typeof(Bank), (customerDetail.salaryReceivedIn)),
                desiredLoanAmount = customerDetail.desiredLoanAmount,
                gender = customerDetail.gender,
                pincode = customerDetail.pincode,
                panCardNumber = customerDetail.panCardNumber,
                dateOfBirth = customerDetail.dateOfBirth,
                email = customerDetail.email,
                company = customerDetail.company,
                currentEMIAmount = customerDetail.currentEMIAmount,
                tenure = customerDetail.tenure,
                experience = customerDetail.experience,
                haveLoan = (Loan)Enum.Parse(typeof(Loan), (customerDetail.haveLoan))
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete([Bind(Include="id")]CustomerModel model)
        {
                new CustomerRepository().DeleteCustomer(model.id);
                return RedirectToAction("Index");
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Script()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ScriptError()
        {
            return View();
        }
    }
}