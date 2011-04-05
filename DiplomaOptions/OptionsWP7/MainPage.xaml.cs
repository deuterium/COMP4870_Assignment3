using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace OptionsWP7
{
    public partial class MainPage : PhoneApplicationPage
    {
        StudentOptionsService.StudentOptionsServiceClient prxy;
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            prxy = new StudentOptionsService.StudentOptionsServiceClient();

            prxy.GetStudentChoicesCompleted += new EventHandler<StudentOptionsService.GetStudentChoicesCompletedEventArgs>(prxy_GetStudentChoicesCompleted);
        }

        void prxy_GetStudentChoicesCompleted(object sender, StudentOptionsService.GetStudentChoicesCompletedEventArgs e)
        {
            textBlock1.Text = "Results: " + e.Result.Count;
            lbSelections.ItemsSource = e.Result.Select(s => s);
        }

        private void tbYear_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            tbYear.Text = "";
        }

        private void buttonGetSelections_Click(object sender, RoutedEventArgs e)
        {
            prxy.GetStudentChoicesAsync(Convert.ToInt32(tbYear.Text));
        }
    }
}