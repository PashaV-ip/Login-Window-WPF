using Login_Window.Core;
using Login_Window.Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Login_Window
{
    /// <summary>
    /// Логика взаимодействия для PageWithSchedule.xaml
    /// </summary>
    public partial class PageWithSchedule : Page
    {
        //private readonly FileReader _fileReader;
        public PageWithSchedule()
        {
            InitializeComponent();
            //_fileReader = new FileReader();
            //LessonComboBox.ItemsSource = FileReader.FileReadLessons();
            //TeacherComboBox.ItemsSource = FileReader.FileReadTeacher();
            (DataContext as MainWindowViewModel).ReadFiles();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as MainWindowViewModel).AddListViewInfo(TeacherComboBox.SelectedItem, LessonComboBox.SelectedItem);
            //if (TeacherComboBox.SelectedItem != null && LessonComboBox.SelectedItem != null)
            //{
            //    string lessonInfo = (TeacherComboBox.SelectedItem as Teacher).NameTeacher + ", " + (LessonComboBox.SelectedItem as Lessons).Name;
            //    ListLessonsInfo.Items.Add(lessonInfo);
            //}
        }
    }
}
