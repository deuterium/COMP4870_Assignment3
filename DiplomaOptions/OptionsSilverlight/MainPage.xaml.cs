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

namespace OptionsSilverlight
{
    public partial class MainPage : UserControl
    {
        StudentOptionsService.StudentOptionsServiceClient prxy = new StudentOptionsService.StudentOptionsServiceClient();

        public MainPage()
        {
            InitializeComponent();

            prxy.GetOptionsCompleted += new EventHandler<GetOptionsCompletedEventArgs>(prxy_GetOptionsCompleted);
            prxy.GetOptionsAsync();

            prxy.AddOptionSelectionCompleted += new EventHandler<AddOptionSelectionCompletedEventArgs>(prxy_AddOptionSelectionCompleted);
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

            prxy.AddOptionSelectionAsync(selection);
        }
    }
}
