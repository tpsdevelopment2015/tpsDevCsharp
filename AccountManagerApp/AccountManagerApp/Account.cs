using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagerApp
{
    class Account
    {
        public string acctName { get; set; }
        public string acctNumber { get; set; }
        public string acctUserName { get; set; }
        public string acctPassword { get; set; }
        public string acctNotes { get; set; }

        public Account(string name, string number, string userName, string password, string notes)
        {
            acctName = name;
            acctNumber = number;
            acctUserName = userName;
            acctPassword = password;
            acctNotes = notes;

        }//end constructor


    }//end class
}//end namespace
