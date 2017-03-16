using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountBook.Repositories;

namespace AccountBook.Models
{
    public class AccountBookService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<AccountBook> _accountBook;

        public AccountBookService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _accountBook = new Repository<AccountBook>(unitOfWork);
        }

        public IEnumerable<AccountViewModel> Lookup()
        {
            var source = _accountBook.LookupAll();
            var result=source.Select(d => 
                new AccountViewModel              
                {
                    ID = d.Id,
                    類別代號 = d.Categoryyy,
                    類別名稱 =(d.Categoryyy==0?"收入":"支出"),
                    日期 = d.Dateee,
                    金額 = d.Amounttt,
                    備註 = d.Remarkkk
                }
           ).ToList();
            return result;
        }
    }
}