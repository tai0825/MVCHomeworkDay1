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
            var accountResult = new List<AccountingModel>();

            for (int i = 1; i < 5; i++)
            {
                accountResult.Add(new AccountingModel
                {
                    Id = i,
                    Category = i % 2 == 0 ? "收入" : "支出",
                    Amount = i * 100,
                    Date = DateTime.Now.AddDays(i)
                });
            }

            return accountResult;
        }
    }
}