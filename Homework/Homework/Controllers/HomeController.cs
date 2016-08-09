using Homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Homework.Controllers
{
    public class HomeController : Controller
    {
        private readonly SkillTreeHomeworkEntities _db = new SkillTreeHomeworkEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Accounting()
        {
            var accountData = GetAccountingData();
            return View(accountData);
        }

        public ActionResult PartialView()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult ChildAction()
        {
            var accountData = GetAccountingData();

            return View(accountData);
        }

        public ActionResult AjaxAction()
        {
            Thread.Sleep(1000);
            ViewData.Model = GetAccountingData();
            return View();
        }

        public List<AccountingModel> GetAccountingData()
        {
            var accountResult = _db.AccountBook.Select(a => new AccountingModel
            {
                Amount = a.Amounttt,
                Category = a.Categoryyy == 0 ? "支出" : "收入",
                Date = a.Dateee,
            }).ToList();

            return accountResult;
        }
    }
}