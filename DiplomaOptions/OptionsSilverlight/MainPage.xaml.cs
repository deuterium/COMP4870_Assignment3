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
using System.Text.RegularExpressions;

namespace OptionsSilverlight
{
    public partial class MainPage : UserControl
    {

        public MainPage()
        {
            InitializeComponent();

            StudentOptionsService.StudentOptionsServiceClient prxy = new StudentOptionsService.StudentOptionsServiceClient();
            prxy.GetOptionsCompleted += new EventHandler<GetOptionsCompletedEventArgs>(prxy_GetOptionsCompleted);
            prxy.GetOptionsAsync();
        }

        void prxy_AddOptionSelectionCompleted(object sender, AddOptionSelectionCompletedEventArgs e)
        {
            CompletePopup c = new CompletePopup();
            c.Show();
            clearFields();
        }

        void prxy_GetOptionsCompleted(object sender, GetOptionsCompletedEventArgs e)
        {
            FirstOption.ItemsSource = e.Result.Select(o => o.Title);
            SecondOption.ItemsSource = e.Result.Select(o => o.Title);
            ThirdOption.ItemsSource = e.Result.Select(o => o.Title);
            FourthOption.ItemsSource = e.Result.Select(o => o.Title);
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
            string results = String.Empty;
            if ((results = isValidInput()).Equals(String.Empty))
            {
                SelectionDetail selection = new SelectionDetail()
                {
                    StudentNumber = StudentNumber.Text,
                    FirstName = FirstName.Text,
                    LastName = LastName.Text,
                    FirstChoice = FirstOption.SelectedValue.ToString(),
                    SecondChoice = SecondOption.SelectedValue.ToString(),
                    ThirdChoice = ThirdOption.SelectedValue.ToString(),
                    FourthChoice = FourthOption.SelectedValue.ToString()
                };

                StudentOptionsService.StudentOptionsServiceClient prxy = new StudentOptionsService.StudentOptionsServiceClient();
                prxy.AddOptionSelectionCompleted += new EventHandler<AddOptionSelectionCompletedEventArgs>(prxy_AddOptionSelectionCompleted);
                prxy.AddOptionSelectionAsync(selection);
            }
            else
            {
                ErrorWindow ew = new ErrorWindow(results);
                ew.Show();
            }
        }

        private string isValidInput()
        {
            string ErrorMessage = String.Empty;

            if (StudentNumber.Text.Equals(String.Empty)) {
                ErrorMessage += "Student number is required.\n";
            } else if (!(Regex.IsMatch(StudentNumber.Text, "^[aA]0{2}[0-9]{6}$"))) {
                ErrorMessage += "Student number must be in in A00###### format.\n";
            }

            if (FirstName.Text.Equals(String.Empty)) {
                ErrorMessage += "First name is required.\n";
            } else if (!Regex.IsMatch(FirstName.Text, "^[A-Za-z']+$")) {
                ErrorMessage += "First name can only contain letters.\n";
            }

            if (LastName.Text.Equals(String.Empty)) {
                ErrorMessage += "Last name is required.\n";
            } else if (!Regex.IsMatch(LastName.Text, "^[A-Za-z']+$")) {
                ErrorMessage += "Last name can only contain letters.\n";
            }
                        
            if (FirstOption.SelectedIndex < 0) {
                ErrorMessage += "First option selection required.\n";
            }

            if (SecondOption.SelectedIndex < 0)
            {
                ErrorMessage += "Second option selection required.\n";
            }

            if (ThirdOption.SelectedIndex < 0)
            {
                ErrorMessage += "Third option selection required.\n";
            }

            if (FourthOption.SelectedIndex < 0)
            {
                ErrorMessage += "Fourth option selection required.\n";
            }

            return ErrorMessage + isSameChoiceSelectedMultipleTimes();
        }

        private string isSameChoiceSelectedMultipleTimes()
        {
            string str = null;
            Dictionary<string, string> choices = new Dictionary<string, string>();
            if (!(this.FirstOption.SelectedIndex < 0))
            {
                choices.Add(this.FirstOption.SelectedItem.ToString(), "First Option");
            }
            if (!(this.FirstOption.SelectedIndex < 0))
            {
                if (!(this.SecondOption.SelectedIndex < 0))
                {
                    if (choices.ContainsKey(this.SecondOption.SelectedItem.ToString()))
                    {
                        str = ((str + "\n") + "'" + this.SecondOption.SelectedItem.ToString() + "'") + " cannot be chosen more than once.";
                    }
                    else
                    {
                        choices.Add(this.SecondOption.SelectedItem.ToString(), "Second Option");
                    }
                }
            }
            if (!(this.ThirdOption.SelectedIndex < 0))
            {
                if (!(this.ThirdOption.SelectedIndex < 0))
                {
                    if (choices.ContainsKey(this.ThirdOption.SelectedItem.ToString()))
                    {
                        str = ((str + "\n") + "'" + this.ThirdOption.SelectedItem.ToString() + "'") + " cannot be chosen more than once.";
                    }
                    else
                    {
                        choices.Add(this.ThirdOption.SelectedItem.ToString(), "Third Option");
                    }
                }
            }
            if (!(this.ThirdOption.SelectedIndex < 0))
            {
                if (choices.ContainsKey(this.FourthOption.SelectedItem.ToString()))
                {
                    return ((((str + "\n") + "'" + this.FourthOption.SelectedItem.ToString() + "'") + " has been chosen more than once."));
                }
                choices.Add(this.FourthOption.SelectedItem.ToString(), "Fourth Option");
            }
            return str;
        }
    }
}
