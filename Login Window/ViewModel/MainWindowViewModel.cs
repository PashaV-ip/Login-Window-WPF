using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Window.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        private User _user;
        private string _information;
        public User User
        {
            get => _user;
            set
            {
                _user = value;
                OnPropertyChanged(nameof(User));
            }
        }
        public string Information
        {
            get => _information;
            set
            {
                _information = value;
                OnPropertyChanged(nameof(Information));
            }
        }
        public MainWindowViewModel()
        {
            _user = new User();
        }
    }
}
