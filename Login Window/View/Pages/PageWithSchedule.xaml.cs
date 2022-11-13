﻿using Login_Window.Core;
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
        public PageWithSchedule()
        {
            InitializeComponent();
            (DataContext as PageWithScheduleViewModel).ReadFiles();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as PageWithScheduleViewModel).AddListViewInfo(TeacherComboBox.SelectedItem, LessonComboBox.SelectedItem);
        }
    }
}
