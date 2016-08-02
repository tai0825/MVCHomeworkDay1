using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework.Models
{
    public class AccountingModel
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
    }
}