using Online_LoanEnquiry_And_Loan_Calculator_BL;
using Online_LoanEnquiry_And_Loan_Calculator_EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Online_LoanEnquiry_And_Loan_Calculator_DAL;
using Online_LoanEnquiry_And_Loan_Calculator.Models;

namespace Online_LoanEnquiry_And_Loan_Calculator.Controllers
{
    public class LoanController : Controller
    {
        LoanBL loanBL = new LoanBL();
        // GET: Loan
        public ActionResult AddLoan()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddLoan(LoanModel model)
        {
            if (ModelState.IsValid)
            {
                var mapper = AutoMapper.Mapper.Map<LoanModel, Loan>(model);
                loanBL.AddLoanDetail(mapper);
                ViewBag.Status = "Add loan details Successful";
                return RedirectToAction("LoanView","Loan");
            }
            return View(model);
        }
        public ActionResult EditLoan(int id)
        {
            CustomerDBContext context = new CustomerDBContext();
            Loan loanDetail = context.loans.Find(id);
            var mapper = AutoMapper.Mapper.Map<Loan, LoanModel>(loanDetail);
            return View(mapper);
        }
        [HttpPost]
        public ActionResult EditLoan(LoanModel model)
        {
            if(ModelState.IsValid)
            {
                var mapper = AutoMapper.Mapper.Map<LoanModel, Loan>(model);
                loanBL.EditLoanDetail(mapper);
                return RedirectToAction("LoanView", "Loan");
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult DeleteLoan(int id)
        {
            CustomerDBContext context = new CustomerDBContext();
            Loan loanDetail = context.loans.Find(id);
            var mapper = AutoMapper.Mapper.Map<Loan,LoanModel>(loanDetail);
            return View(mapper);
        }
       [HttpPost]
        public ActionResult Delete(int id)
        {
            loanBL.DeleteLoanDetail(id);
            return RedirectToAction("LoanView", "Loan");
        }
        public ActionResult LoanView()
        {
            IEnumerable<Loan> loanDetails = loanBL.GetLoans();
            return View(loanDetails);
        }
    }
}