using Login_Window.ViewModel;
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
using System.Windows.Shapes;

namespace Login_Window
{
    /// <summary>
    /// Логика взаимодействия для WindowWithSchedule.xaml
    /// </summary>
    public partial class WindowWithSchedule : Window
    {
        public WindowWithSchedule()
        {
            InitializeComponent();
            FrameWithPages.Navigate(new PageWithSchedule());
        }

        private void ScheduleButton_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as MainWindowViewModel).ScheduleOpenPage();
        }
    }
}
