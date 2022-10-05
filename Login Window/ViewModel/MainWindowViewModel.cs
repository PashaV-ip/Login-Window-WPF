using Login_Window.Core;
using Login_Window.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
        public void ExitMethod()
        {
            foreach (Window item in Application.Current.Windows)
            {
                if (item is MainWindow)
                {
                    item.Close();
                }
            }
        }
        public void ValidationMethod()
        {
            if (string.IsNullOrWhiteSpace(User.Login) || string.IsNullOrWhiteSpace(User.Password))
                MessageBox.Show("Какое-то поле пустое!", "Ошибка..", MessageBoxButton.OK, MessageBoxImage.Warning);
            else
            {
                if (Validation.Validation_Method(User) == true)
                {
                    MessageBox.Show("Вы успешно авторизировались!", "успех..", MessageBoxButton.OK, MessageBoxImage.Information);
                    WindowWithSchedule windowWithSchedule = new WindowWithSchedule();
                    windowWithSchedule.Show();
                    ExitMethod();
                }
                else MessageBox.Show("Неправельный логин или пароль!", "Ошибка..", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        public MainWindowViewModel()
        {
            _user = new User();
        }
    }
}
