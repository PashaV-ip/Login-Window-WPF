using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Login_Window
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Entrance_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(loginTextBox.Text) || string.IsNullOrWhiteSpace(passwordBox.Password))
                MessageBox.Show("Какое-то поле пустое!", "Ошибка..", MessageBoxButton.OK, MessageBoxImage.Warning);
            else
            {
                if (Validation.Validation_Method(loginTextBox.Text, passwordBox.Password) == true)
                {
                    MessageBox.Show("Вы успешно авторизировались!", "успех..", MessageBoxButton.OK, MessageBoxImage.Information);
                    WindowWithSchedule windowWithSchedule = new WindowWithSchedule();
                    windowWithSchedule.Show();
                    this.Close();
                }
                else MessageBox.Show("Неправельный логин или пароль!", "Ошибка..", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
