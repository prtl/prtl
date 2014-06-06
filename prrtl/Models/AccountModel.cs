using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prrtl.Models
{
    public class AccountModel
    {
        public List<Accounts> Accounts { get; set; }
        public Accounts Account { get; set; }
        
    }

    public class Accounts 
    {
        public string AccId { get; set; }
        public string AccName { get; set; }
        public string AccPw { get; set; }
        public int AccLevel { get; set; }
    }
}