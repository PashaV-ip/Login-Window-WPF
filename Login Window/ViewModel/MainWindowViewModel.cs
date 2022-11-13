using Login_Window.Command;
using Login_Window.Core;
using Login_Window.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

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
        private void Exit()
        {
            foreach (Window item in Application.Current.Windows)
            {
                if (item is MainWindow)
                {
                    item.Close();
                }
            }
        }
        public void ExitMethod(object Object)
        {
            Exit();
        }

        public ICommand ExitCommand { get; }
        public void ValidationMethod(object Object)
        {
            if (string.IsNullOrWhiteSpace(User.Login) || string.IsNullOrWhiteSpace(User.Password))
                MessageBox.Show("Какое-то поле пустое!", "Ошибка..", MessageBoxButton.OK, MessageBoxImage.Warning);
            else
            {
                if (Validation.Validation_Method(User))
                {
                    MessageBox.Show("Вы успешно авторизировались!", "успех..", MessageBoxButton.OK, MessageBoxImage.Information);
                    WindowWithSchedule windowWithSchedule = new WindowWithSchedule();
                    windowWithSchedule.Show();
                    Exit();
                }
                else MessageBox.Show("Неправельный логин или пароль!", "Ошибка..", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        public ICommand ValidationCommand { get; }


        public void PasswordChanged(object Object)
        {
            MainWindow window = new MainWindow();
            User.Password = window.passwordBox.Password;
        }
        public ICommand PasswordChangedCommand { get; }


        public MainWindowViewModel()
        {
            _user = new User();
            ExitCommand = new RelativCommand(ExitMethod);
            ValidationCommand = new RelativCommand(ValidationMethod);
            PasswordChangedCommand = new RelativCommand(PasswordChanged);
        }
    }
}
