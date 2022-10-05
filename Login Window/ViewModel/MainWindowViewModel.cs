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
        private ObservableCollection<Lessons> _lessonList;
        private ObservableCollection<Teacher> _teacherList;
        private ObservableCollection<string> _listInfoForLessons;
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
        public ObservableCollection<Lessons> LessonList
        {
            get => _lessonList;
            set
            {
                _lessonList = value;
                OnPropertyChanged(nameof(LessonList));
            }
        }
        public ObservableCollection<Teacher> TeacherList
        {
            get => _teacherList;
            set
            {
                _teacherList = value;
                OnPropertyChanged(nameof(TeacherList));
            }
        }
        public ObservableCollection<string> ListInfoForLessons
        {
            get => _listInfoForLessons;
            set
            {
                _listInfoForLessons = value;
                OnPropertyChanged(nameof(ListInfoForLessons));
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
        public void ScheduleOpenPage()
        {
            WindowWithSchedule windowWithSchedule = new WindowWithSchedule();
            windowWithSchedule.FrameWithPages.Navigate(new PageWithSchedule());
        }

        public void ReadFiles()
        {
            LessonList = FileReader.FileReadLessons();
            TeacherList = FileReader.FileReadTeacher();
        }

        public void AddListViewInfo(object TeacherSelected, object LessonSelected)
        {
            if (TeacherSelected != null && LessonSelected != null)
            {
                string lessonInfo = (TeacherSelected as Teacher).NameTeacher + ", " + (LessonSelected as Lessons).Name;
                ObservableCollection<string> lessons = ListInfoForLessons;
                lessons.Add(lessonInfo);
                ListInfoForLessons = lessons;
                //ListLessonsInfo.Items.Add(lessonInfo);
            }
        }

        public MainWindowViewModel()
        {
            _user = new User();
            _lessonList = new ObservableCollection<Lessons>();
            _teacherList = new ObservableCollection<Teacher>();
            _listInfoForLessons = new ObservableCollection<string>();
        }
    }
}
