using System;
using System.Collections.Generic;

using Xamarin.Forms;

using SWMSoftMockUp3.Views;
using SWMSoftMockUp3.CustomControls;

namespace SWMSoftMockUp3.Views.Templates
{
    public partial class LoginServerPage : ContentPage
    {

        bool _serverIsSet = false;

        //bool _firstLogin = true;

        public LoginServerPage()
        {
            InitializeComponent();
            //LoginBox.Children.Add(new TestView());
            if (!_serverIsSet)
            {
                //_firstLogin = false;
                ServerBox.IsVisible = true;

            }
            else
            {
                ServerBox.IsVisible = false; //don't show server box if server is already set
            }
            
        }

        private void SetServerButton_Clicked(object sender, EventArgs e)
        {
            _serverIsSet = true;
            ServerBox.IsVisible = false;
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("LoginPage","Login Successful","Ok");
        }
    }
}
