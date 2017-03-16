using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AccountBook.Models;
using AccountBook.Repositories;

namespace AccountBook.Controllers
{
    public class HomeController : Controller
    {
        private readonly AccountBookService _accountBookService;

        public HomeController()
        {
            var unitOfWork = new EFUnitOfWork();
            _accountBookService = new AccountBookService(unitOfWork);
        }

        public ActionResult Index()
        {            
            var model = _accountBookService.Lookup();
            return View(model);
        }

    }
}