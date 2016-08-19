using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Homework.Models
{
    public class AccountingModel
    {
        public int Id { get; set; }

        [Display(Name ="類別")]
        public string Category { get; set; }

        [Display(Name ="日期")]
        public DateTime Date { get; set; }

        [Display(Name = "金額")]
        public int Amount { get; set; }

        [Display(Name = "備註")]
        public string Remark { get; set; }
    }
}