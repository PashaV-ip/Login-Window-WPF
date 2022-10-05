using Login_Window.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Window.Core
{
    public class FileReader
    {
        #region Чтение файла с уроками
        public ObservableCollection<Lessons> FileReadLessons()
        {
            var lessonList = new ObservableCollection<Lessons>();
            using (StreamReader streamReader = new StreamReader(@"..\..\Files\Lesson.txt"))
            {
                foreach (var item in streamReader.ReadToEnd().Split('\n'))
                {
                    var arrayString = item.Split('?');
                    if (arrayString[0] != "ID")
                    {
                        Lessons lesson = new Lessons()
                        {
                            Id = int.Parse(arrayString[0]),
                            Name = arrayString[1]
                        };
                        lessonList.Add(lesson);
                    }
                }
            }
            return lessonList;
        }
        #endregion

        #region Чтение файла с Учителями
        public ObservableCollection<Teacher> FileReadTeacher()
        {
            var teacherList = new ObservableCollection<Teacher>();
            using (StreamReader streamReader = new StreamReader(@"..\..\Files\Teachers.txt"))
            {
                foreach (var item in streamReader.ReadToEnd().Split('\n'))
                {
                    var arrayString = item.Split(',');
                    if (arrayString[0] != "ID")
                    {
                        Teacher teacher = new Teacher()
                        {
                            Id = int.Parse(arrayString[0]),
                            FirstName = arrayString[1],
                            LastName = arrayString[2],
                            Login = arrayString[3],
                            Password = arrayString[4]
                        };
                        teacherList.Add(teacher);
                    }
                }
            }
            return teacherList;
        }
        #endregion
    }
}
