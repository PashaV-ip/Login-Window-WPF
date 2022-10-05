using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Window
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public static ObservableCollection<User> GetUserList()
        {
            var listUsers = new ObservableCollection<User>()
            {
                new User()
                {
                    Login = "Prorok755",
                    Password = "75561"
                },
                new User()
                {
                    Login = "Lilia",
                    Password = "15982"
                },
                new User()                             //Ники просто со скриншота списал у левых людей :D
                {
                    Login = "BMX_515",
                    Password = "15g7e33"
                },
                new User()
                {
                    Login = "PRO100_Vasia",
                    Password = "15g7e33"
                }
            };
            return listUsers;
        }
        public User()
        {

        }
        public User(string Login, string Password)
        {
            this.Login = Login;
            this.Password = Password;
        }
    }
}
