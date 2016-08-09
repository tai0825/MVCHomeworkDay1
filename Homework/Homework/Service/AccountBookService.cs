using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Homework.Models;

namespace Homework.Service
{
    public class AccountBookService
    {
        private readonly SkillTreeHomeworkEntities _db = new SkillTreeHomeworkEntities();

        public List<AccountingModel> GetAccountingData()
        {
            var accountResult = _db.AccountBook.Select(a => new AccountingModel
            {
                Amount = a.Amounttt,
                Category = a.Categoryyy == 0 ? "支出" : "收入",
                Date = a.Dateee
            }).ToList();

            return accountResult;
        }
    }
}