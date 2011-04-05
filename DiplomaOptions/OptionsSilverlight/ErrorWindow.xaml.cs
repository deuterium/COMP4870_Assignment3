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

namespace OptionsSilverlight
{
    public partial class ErrorWindow : ChildWindow
    {
        public ErrorWindow(string Errors)
        {
            InitializeComponent();
            textBlock1.Text = Errors;
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}

