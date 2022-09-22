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
            var listUsers = User.GetUserList();
            foreach(User user in listUsers)
                if (Login == user.Login && Password == user.Password)
                    return true;
            return false;
        }
    }
}
