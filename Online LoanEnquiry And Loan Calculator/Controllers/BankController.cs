using Online_LoanEnquiry_And_Loan_Calculator.Models;
using Online_LoanEnquiry_And_Loan_Calculator_BL;
using Online_LoanEnquiry_And_Loan_Calculator_DAL;
using Bank=Online_LoanEnquiry_And_Loan_Calculator_EL.Bank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online_LoanEnquiry_And_Loan_Calculator.Controllers
{
    public class BankController : Controller
    {
        BankBL bankBL = new BankBL();
        // GET: Loan
        public ActionResult AddBank()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddBank(BankModel model)
        {
            if (ModelState.IsValid)
            {
                var mapper = AutoMapper.Mapper.Map<BankModel,Bank>(model);
                bankBL.AddBankDetail(mapper);
                ViewBag.Status = "Add bank details Successful";
                return RedirectToAction("BankView", "Bank");
            }
            return View(model);
        }
        public ActionResult EditBank(int id)
        {
            CustomerDBContext context = new CustomerDBContext();
            Bank bankDetail = context.banks.Find(id);
            var mapper = AutoMapper.Mapper.Map<Bank, BankModel>(bankDetail);
            return View(mapper);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditBank(BankModel model)
        {
            if (ModelState.IsValid)
            {
                var mapper = AutoMapper.Mapper.Map<BankModel, Bank>(model);
                bankBL.EditBankDetail(mapper);
                return RedirectToAction("BankView", "Bank");
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult DeleteBank(int id)
        {
            CustomerDBContext context = new CustomerDBContext();
            Bank bankDetail = context.banks.Find(id);
            var mapper = AutoMapper.Mapper.Map<Bank, BankModel>(bankDetail);
            return View(mapper);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int bankid)
        {
            bankBL.DeleteBankDetail(bankid);
            return RedirectToAction("BankView", "Bank");
        }
        public ActionResult BankView()
        {
            IEnumerable<Bank> bankDetails = bankBL.GetBanks();
            return View(bankDetails);
        }

    }
}