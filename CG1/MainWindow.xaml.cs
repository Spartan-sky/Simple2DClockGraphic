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

namespace CG1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void UpdateTimeClick(object sender, RoutedEventArgs e)
        {
            DisplayTime.Text =
                (((int)ActualTimeHour.Angle)/30).ToString() + ":" +
                (((int)ActualTimeMinute.Angle)/6).ToString() + ":" +
                (((int)ActualTimeSecond.Angle)/6).ToString();
        }
    }
}
