using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using tramcan2.models;

namespace tramcan2.API
{
     public class Account
    {
        private static Account instance;
        public static Account Instance
        {
            get { if (instance == null) instance = new Account(); return instance; }
            private set { instance = value; }
        }
        private Account() { }
        CanDbcontext db = new CanDbcontext();
        public bool login(string username, string password)
        {
           
           string login_t = "nhat123";
           User user = db.users.Find(login_t);


            return  true ;     
        }
    }
}
