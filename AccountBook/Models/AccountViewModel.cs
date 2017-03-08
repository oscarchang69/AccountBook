using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountBook.Models
{
    public class AccountViewModel
    {
        public int 類別代號 { get; set; }
        public string 類別名稱 { get; set; }
        public DateTime 日期 { get; set; }
        public int 金額 { get; set; }
    }
}