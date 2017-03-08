using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AccountBook.Models;

namespace AccountBook.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new List<AccountViewModel>
            {
                new AccountViewModel
                {
                    類別代號= 1,
                    類別名稱="支出",
                    日期=Convert.ToDateTime("2016-01-01"),
                    金額=300

                },
                new AccountViewModel
                {
                     類別代號= 1,
                     類別名稱="支出",
                     日期=Convert.ToDateTime("2016-01-01"),
                     金額=1600
                },
                new AccountViewModel
                {
                    類別代號= 1,
                    類別名稱="支出",
                    日期=Convert.ToDateTime("2016-01-03"),
                    金額=800
                }
            };
            return View(model);
        }

    }
}