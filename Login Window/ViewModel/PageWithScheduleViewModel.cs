using Login_Window.Command;
using Login_Window.Core;
using Login_Window.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Login_Window.ViewModel
{
    public class PageWithScheduleViewModel : BaseViewModel
    {
        private ObservableCollection<Lessons> _lessonList;
        private ObservableCollection<Teacher> _teacherList;
        private ObservableCollection<string> _listInfoForLessons;
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
        public async void ReadFiles()
        {
            LessonList = await FileReader.FileReadLessons();
            TeacherList = await FileReader.FileReadTeacher();
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

        public PageWithScheduleViewModel()
        {
            _lessonList = new ObservableCollection<Lessons>();
            _teacherList = new ObservableCollection<Teacher>();
            _listInfoForLessons = new ObservableCollection<string>();
        }
    }
}
