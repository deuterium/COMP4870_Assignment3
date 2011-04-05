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
            string valid;
            if ((valid = Validation()) == null)
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
                ErrorWindow err = new ErrorWindow(valid);
                err.Show();
            }
        }

        private string Validation()
        {
            string ErrorMesage = "";
            if (StudentNumber.Text.Length == 0)
            {
                ErrorMesage += "Student number is required.,";
            }
            else if (StudentNumber.Text.Length != 0 && !Regex.IsMatch(StudentNumber.Text, "^[aA]0{2}[0-9]{6}")) 
            {
                ErrorMesage += "Student number must be in A00###### format.,";
            }
            else if (FirstName.Text.Length == 0)
            {
                ErrorMesage += "First name is required.,";
            }
            else if (LastName.Text.Length == 0)
            {
                ErrorMesage += "Last name is required.,";
            }
            else if (FirstOption.SelectedIndex == -1)
            {
                ErrorMesage += "First option selection required.,";
            }
            else if (SecondOption.SelectedIndex == -1)
            {
                ErrorMesage += "Second option selection required.,";
            }
            else if (ThirdOption.SelectedIndex == -1)
            {
                ErrorMesage += "Third option selection required.,";
            }
            else if (FourthOption.SelectedIndex == -1)
            {
                ErrorMesage += "Fourth option selection required.,";
            }
            else
            {
                return ErrorMesage;
            }
            return null;
        }
    }
}
