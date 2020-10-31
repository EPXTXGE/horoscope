﻿using System;
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

namespace horoscope
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
        private void rBlue_Checked(object sender, RoutedEventArgs e)
        {
            recColor.Fill = Brushes.Blue;
        }

        private void rYellow_Checked(object sender, RoutedEventArgs e)
        {
            recColor.Fill = Brushes.Yellow;
        }

        private void rOrange_Checked(object sender, RoutedEventArgs e)
        {
            recColor.Fill = Brushes.Orange;
        }


    }

}
