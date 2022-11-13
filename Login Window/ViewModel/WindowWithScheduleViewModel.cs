using Login_Window.Command;
using Login_Window.View.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Login_Window.ViewModel
{
    public class WindowWithScheduleViewModel : BaseViewModel
    {
        public void ScheduleOpenPage(object Object)
        {
            WindowWithSchedule windowWithSchedule = new WindowWithSchedule();
            windowWithSchedule.FrameWithPages.Navigate(new PageWithSchedule());
            windowWithSchedule.Close();
        }
        public ICommand OpenSchedulePageCommand { get; }

        public void TeacherOpenPage(object Object)
        {
            WindowWithSchedule windowWithSchedule = new WindowWithSchedule();
            windowWithSchedule.FrameWithPages.Navigate(new PageTeacher());
            windowWithSchedule.Close();
        }
        public ICommand OpenTeacherPageCommand { get; }
        public WindowWithScheduleViewModel()
        {
            OpenSchedulePageCommand = new RelativCommand(ScheduleOpenPage);
            OpenTeacherPageCommand = new RelativCommand(TeacherOpenPage);
        }
    }
}
