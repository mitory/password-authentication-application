using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password_lab
{
    public class Account
    {
        public Account(string login, string password, bool isBlocked, bool isRestPass)
        {
            this.login = login;
            this.password = password;
            this.isBlocked = isBlocked;
            this.isRestPass = isRestPass;
        }
        public string login;
        public string password;
        public bool isBlocked;
        public bool isRestPass;
    }
}
