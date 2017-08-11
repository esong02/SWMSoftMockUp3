﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

using SWMSoftMockUp3.CustomControls;
using SWMSoftMockUp3.Models;

namespace SWMSoftMockUp3.Views.Templates
{
    public partial class HeaderPage : ContentPage
    {
        public HeaderPage()
        {
            InitializeComponent();
        }

		async void OnCallLocationMapPage()
		{
			AssetLocation location = new AssetLocation
			{
				TaskId = 10,
				address = "Sample"
			};
			await Navigation.PushAsync(new LocationMapPage(location));
		}

		void MapView_Tapped(object sender, System.EventArgs e)
		{
			OnCallLocationMapPage();
		}

    }
}
