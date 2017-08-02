using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SWMSoftMockUp3.Views
{
    public partial class LocationMapPage : ContentPage
    {
        public LocationMapPage(int id, string address)
        {
            InitializeComponent();
            Title = "Task " + id;
            //var navPage = Application.Current.MainPage as NavigationPage;
            //navPage.BarBackgroundColor = Color.White;
            LocationText.Text = LocationText.Text + " " + address;
        }
    }
}
