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
using Online_LoanEnquiry_And_Loan_Calculator_BL;
using Type = Online_LoanEnquiry_And_Loan_Calculator.Models.Type;
using Bank = Online_LoanEnquiry_And_Loan_Calculator.Models.Bank;
using System.Web.Security;

namespace Online_LoanEnquiry_And_Loan_Calculator.Controllers
{
    public class CustomerController : Controller
    {
        CustomerBL customerBL = new CustomerBL();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ToCalculate()
        {
            return View();
        }
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registration(CustomerModel model)
        {
            if (ModelState.IsValid)
            {
                model.role = Role.User;
                var mapper=AutoMapper.Mapper.Map<CustomerModel,Customer>(model);
                //id = model.id,
                //name = model.name,
                //type = Convert.ToString(model.type),
                //monthlyIncome = model.monthlyIncome,
                //mobilenumber = model.mobilenumber,
                //residentArea = model.residentArea,
                //salaryReceivedIn = Convert.ToString(model.salaryReceivedIn),
                //desiredLoanAmount = model.desiredLoanAmount,
                //gender = model.gender,
                //pincode = model.pincode,
                //panCardNumber = model.panCardNumber,
                //dateOfBirth = model.dateOfBirth,
                //email = model.email,
                //company = model.company,
                //currentEMIAmount = model.currentEMIAmount,
                //tenure = model.tenure,
                //experience = model.experience,
                //haveLoan = Convert.ToString(model.haveLoan),
                //Role = "Customer",
                //password=model.password
                customerBL.AddCustomerDetail(mapper);
                ViewBag.Status = "Registration Successful";
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public ActionResult Edit(int id)
        {
            CustomerDBContext context = new CustomerDBContext();
            Customer customerDetail = context.customers.Find(id);
            CustomerModel model = new CustomerModel
            {
                customerid = customerDetail.customerid,
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
                haveLoan = (Loans)Enum.Parse(typeof(Loans), (customerDetail.haveLoan)),
                password=customerDetail.password
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "customerid,name,type,monthlyIncome,mobilenumber,residentArea,salaryReceivedIn,desiredLoanAmount,gender,pincode,panCardNumber,dateOfBirth,email,company,currentEMIAmount,tenure,experience,haveLoan")]CustomerModel model)
        {
            if (ModelState.IsValid)
            {
                Customer customer = new Customer
                {
                    customerid = model.customerid,
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
                    haveLoan = Convert.ToString(model.haveLoan),
                    password=model.password
                };
                customerBL.EditCustomerDetail(customer);
                return RedirectToAction("AdminPage","Admin");
            }
            return View(model);
        }
        public ActionResult Delete(int id)
        {
            CustomerDBContext context = new CustomerDBContext();
            Customer customerDetail = context.customers.Find(id);
            //CustomerModel model = new CustomerModel
            //{
            //    id = customerDetail.customerid,
            //    name = customerDetail.name,
            //    type = (Type)Enum.Parse(typeof(Type), (customerDetail.type)),
            //    monthlyIncome = customerDetail.monthlyIncome,
            //    mobilenumber = customerDetail.mobilenumber,
            //    residentArea = customerDetail.residentArea,
            //    salaryReceivedIn = (Bank)Enum.Parse(typeof(Bank), (customerDetail.salaryReceivedIn)),
            //    desiredLoanAmount = customerDetail.desiredLoanAmount,
            //    gender = customerDetail.gender,
            //    pincode = customerDetail.pincode,
            //    panCardNumber = customerDetail.panCardNumber,
            //    dateOfBirth = customerDetail.dateOfBirth,
            //    email = customerDetail.email,
            //    company = customerDetail.company,
            //    currentEMIAmount = customerDetail.currentEMIAmount,
            //    tenure = customerDetail.tenure,
            //    experience = customerDetail.experience,
            //    haveLoan = (Loans)Enum.Parse(typeof(Loans), (customerDetail.haveLoan)),
            //    password = customerDetail.password
            //};
            var model = AutoMapper.Mapper.Map<Customer, CustomerModel>(customerDetail);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteUser(int id)
        {
            customerBL.DeleteCustomerDetail(id);
            return RedirectToAction("AdminPage","Admin");
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(CustomerModel model)
        {
            var user = AutoMapper.Mapper.Map<CustomerModel, Customer>(model);
            Customer value = CustomerRepository.CheckLogin(user);
            if (value != null)
            {
                FormsAuthentication.SetAuthCookie(Convert.ToString(user.mobilenumber), false);
                var authTicket = new FormsAuthenticationTicket(1, Convert.ToString(user.mobilenumber), DateTime.Now, DateTime.Now.AddMinutes(20), false, user.role);
                string encryptedTicket = FormsAuthentication.Encrypt(authTicket);
                var authCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
                HttpContext.Response.Cookies.Add(authCookie);
                if (value.role.Equals("User"))
                {
                    ViewBag.value = "Logged in Successfully as Customer";
                    return RedirectToAction("Index", "Customer");
                }
                else if (value.role.Equals("Admin"))
                {
                    ViewBag.value = "Logged in successfully as Admin";
                    return RedirectToAction("AdminPage","Admin");   
                }
                else
                {
                    ViewBag.value = "Please enter correct details";
                    return View();
                }
            }
            else
            {
                ViewBag.value = "Please enter the correct details";
                return View();
            }
        }
        [AllowAnonymous]
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Customer");
        }
        public ActionResult CustomerView()
        {
            IEnumerable<Customer> customerdetails = new CustomerRepository().GetCustomers();
            return View(customerdetails);
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