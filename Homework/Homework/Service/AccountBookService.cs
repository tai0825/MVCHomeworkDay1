using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Homework.Models;
using Homework.Repositories;
using System.Web.Mvc;

namespace Homework.Service
{
    public class AccountBookService : Repository<AccountBook>
    {
        private readonly SkillTreeHomeworkEntities _db = new SkillTreeHomeworkEntities();
        private readonly IRepository<AccountBook> _accRepo;

        public AccountBookService(IUnitOfWork unitOfWork): base(unitOfWork)
        {
            _accRepo = new Repository<AccountBook>(unitOfWork);
        }

        public List<AccountingModel> GetAccountingData()
        {
            var accountResult = _db.AccountBook.Select(a => new AccountingModel
            {
                Amount = a.Amounttt,
                Category = a.Categoryyy == 0 ? "支出" : "收入",
                Date = a.Dateee
            }).OrderByDescending(a => a.Date).Take(5).ToList();

            return accountResult;
        }

        public List<SelectListItem> GetCategoryDropDown()
        {
            var result = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Text = "支出",
                    Value = "0",
                    Selected = false,
                },
                new SelectListItem
                {
                    Text = "收入",
                    Value = "1",
                    Selected = false,
                }
            };

            return result;
        }

        //public void Creat(AccountBook data)
        //{

        //}
    }
}