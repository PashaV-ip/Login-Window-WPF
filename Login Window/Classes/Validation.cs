using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Window
{
    public static class Validation
    {
        public static bool Validation_Method(User userVal)
        {
            var listUsers = User.GetUserList();
            foreach(User user in listUsers)
                if (userVal.Login == user.Login && userVal.Password == user.Password)
                    return true;
            return false;
        }
    }
}
