using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Homework.Models;
using Homework.Service;
using Homework.Repositories;

namespace Homework.Areas.PartialArea.Controllers
{
    public class PartialController : Controller
    {
        private readonly AccountBookService _accServ;

        public PartialController()
        {
            var unitOfWork = new EFUnitOfWork();
            _accServ = new AccountBookService(unitOfWork);
        }

        // GET: PartialArea/Partial
        public ActionResult Index()
        {
            var result = _accServ.GetAccountingData();
            return View(result);
        }


    }
}