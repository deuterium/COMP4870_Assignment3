﻿using System;
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
using OptionsSilverlight.StudentOptionsService;
using System.Windows.Controls.Primitives;

namespace OptionsSilverlight
{
    public partial class MainPage : UserControl
    {
        StudentOptionsService.StudentOptionsServiceClient prxy = new StudentOptionsService.StudentOptionsServiceClient();

        public MainPage()
        {
            InitializeComponent();

            prxy.getActiveOptionsCompleted += new EventHandler<StudentOptionsService.getActiveOptionsCompletedEventArgs>(prxy_getActiveOptionsCompleted);
            prxy.getActiveOptionsAsync();

            prxy.boolsubmitOptionsCompleted += new EventHandler<boolsubmitOptionsCompletedEventArgs>(prxy_boolsubmitOptionsCompleted);
        }

        void prxy_boolsubmitOptionsCompleted(object sender, boolsubmitOptionsCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        void prxy_getActiveOptionsCompleted(object sender, StudentOptionsService.getActiveOptionsCompletedEventArgs e)
        {
            FirstOption.ItemsSource = e.Result;
            SecondOption.ItemsSource = e.Result;
            ThirdOption.ItemsSource = e.Result;
            FourthOption.ItemsSource = e.Result;
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            clearFields();
        }

        private void clearFields()
        {
            StudentNumber.Text = "";
            FirstName.Text = "";
            LastName.Text = "";
            FirstOption.SelectedIndex = -1;
            SecondOption.SelectedIndex = -1;
            ThirdOption.SelectedIndex = -1;
            FourthOption.SelectedIndex = -1;
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            if (validation() != true)
            {

            }
            else if (validation())
            {
                prxy.boolsubmitOptionsAsync(StudentNumber.Text, FirstName.Text, LastName.Text
                    , FirstOption.SelectedValue.ToString(), SecondOption.SelectedValue.ToString()
                    , ThirdOption.SelectedValue.ToString(), FourthOption.SelectedValue.ToString());
                CompletePopup c = new CompletePopup();
                c.Show();
                clearFields();
            }
        }

        private bool validation() 
        {
            return true;
        }
    }
}
