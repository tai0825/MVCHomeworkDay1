using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Homework.Models;
using Homework.Repositories;

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
            }).ToList();

            return accountResult;
        }
    }
}