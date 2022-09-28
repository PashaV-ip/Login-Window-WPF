using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Window.Models
{
    public class Lessons
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string InfoLessons
        {
            get => Id + ") " + Name;
            set { }
        }
    }
}
