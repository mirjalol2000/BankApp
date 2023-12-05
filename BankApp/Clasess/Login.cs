using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Clasess
{
    public class Login: ILogin
    {
        public List<string> save = new List<string>();
        public string LoginName { get; set; }
        public string Password { get; set; }

        public Login()
        {
            LoginName = "mirjalol";
            Password = "12345";
        }

        public bool Check(string login, string password)
        {
            bool check = false;   
            if(login == LoginName && password == Password)
            {
                check = true;   
            }
            else
            {
                check = false;
            }
                return check;
        }

    }
}
