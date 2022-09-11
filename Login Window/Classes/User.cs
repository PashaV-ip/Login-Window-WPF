using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Window
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public User(string Login, string Password)
        {
            this.Login = Login;
            this.Password = Password;
        }
    }
}
