using System;
using System.Collections.Generic;

using Xamarin.Forms;

using SWMSoftMockUp3.Models;

namespace SWMSoftMockUp3.Views
{
    public partial class LocationMapPage : ContentPage
    {
        public LocationMapPage(object itemObject)
        {
            InitializeComponent();
            string title;
            //string imageLink;
            string locationText;

            var location = itemObject as AssetLocation;

            if (location == null){
                title = "";
                //imageLink = ""; //changed to an empty image
                locationText = "";
            }else{
                 title =  "" +location.TaskId;
                locationText = location.address;
                //imageLink = "";
            }



            Title = "Task " + title;
            //var navPage = Application.Current.MainPage as NavigationPage;
            //navPage.BarBackgroundColor = Color.White;
            LocationText.Text = LocationText.Text + " " + locationText;
        }
    }
}
