﻿using Login_Window.ViewModel;
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
            (DataContext as MainWindowViewModel).ValidationMethod();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as MainWindowViewModel).ExitMethod();
        }

        private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            (DataContext as MainWindowViewModel).User.Password = passwordBox.Password;
        }
    }
}
