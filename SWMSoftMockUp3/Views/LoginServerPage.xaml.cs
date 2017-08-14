using System;
using System.Collections.Generic;

using Xamarin.Forms;

using SWMSoftMockUp3.Models;
using SWMSoftMockUp3.Views;
using SWMSoftMockUp3.CustomControls;

namespace SWMSoftMockUp3.Views
{
    public partial class LoginServerPage : ContentPage
    {
        string currentUser;
        public List<User> _uList;
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

            _uList = new List<User>();

            User u1 = new User
            {
                Id = 1,
                UserName = "aaa",
                UserLogon = "bbb"
            };

            User u2 = new User
            {
                Id = 2,
                UserName = "Alex",
                UserLogon = "123456"
            };

            User u3 = new User
            {
                Id = 3,
                UserName = "Eric",
                UserLogon = "78910"
            };

            _uList.Add(u1);
            _uList.Add(u2);
            _uList.Add(u3);

        }

        void LoginButton_Clicked(object sender, System.EventArgs e)
        {
            var userName = UserName.Text;
            var password = Password.Text;
            bool loginSuccess = false;
            //DisplayAlert("Login",userName + ",\n"+password,"Ok");

            foreach (var user in _uList)
            {
                if (user.UserName.Equals(userName))
                {
                    if (user.UserLogon.Equals(password))
                    {
                        //DisplayAlert("Login","Authentication Successful","Ok");
                        loginSuccess = true;
                        currentUser = userName;
                        break;
                    }
                }
            }

            if (!loginSuccess)
            {
                //DisplayAlert("Login","Login Failed","Ok");
                Password.Text = "";
                Password.Placeholder = "Invalid Password";
            }
            else
            {
                OnCallLocationListPage();
            }


        }

        private void SetServerButton_Clicked(object sender, EventArgs e)
        {
            _serverIsSet = true;
            ServerBox.IsVisible = false;
        }

        async void OnCallLocationListPage()
        {
            await Navigation.PushAsync(new LocationListPage(currentUser));
        }
    }
}
