using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Window.ViewModel
{
    public class WindowWithScheduleViewModel : BaseViewModel
    {
        public void ScheduleOpenPage()
        {
            WindowWithSchedule windowWithSchedule = new WindowWithSchedule();
            windowWithSchedule.FrameWithPages.Navigate(new PageWithSchedule());
        }
    }
}
