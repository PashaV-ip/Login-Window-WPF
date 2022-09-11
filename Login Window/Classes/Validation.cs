using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Window
{
    public static class Validation
    {
        public static bool Validation_Method(string Login, string Password)
        {
            User user1 = new User("Kostia", "123456");
            if(Login == user1.Login && Password == user1.Password)
            return true;
            return false;
        }
    }
}
