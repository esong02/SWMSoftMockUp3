using System;
using System.Collections.Generic;

using Xamarin.Forms;

using SWMSoftMockUp3.Views;
using SWMSoftMockUp3.CustomControls;

namespace SWMSoftMockUp3.Views.Templates
{
    public partial class LoginServerPage : ContentPage
    {
        public LoginServerPage()
        {
            InitializeComponent();
            LoginBox.Children.Add(new TestView());
        }
    }
}
