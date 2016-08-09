﻿using Homework.Models;
using Homework.Service;
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
        private readonly AccountBookService aServ = new AccountBookService();

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
            var accountData = aServ.GetAccountingData();
            return View(accountData);
        }

        public ActionResult PartialView()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult ChildAction()
        {
            var accountData = aServ.GetAccountingData();

            return View(accountData);
        }

        public ActionResult AjaxAction()
        {
            Thread.Sleep(1000);
            ViewData.Model = aServ.GetAccountingData();
            return View();
        }

        
    }
}