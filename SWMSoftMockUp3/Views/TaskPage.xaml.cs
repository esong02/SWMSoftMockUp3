using System;
using System.Collections.Generic;

using SWMSoftMockUp3.CustomControls;
using SWMSoftMockUp3.Models;

using Xamarin.Forms;

namespace SWMSoftMockUp3.Views
{
    public partial class TaskPage : ContentPage
    {

        //Component selectedComponent;

        public TaskPage(Component selectedComponent)
        {
            InitializeComponent();
            Title = selectedComponent.Name;
            MapIcon.ObjReference = selectedComponent;

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

        async void OnCallPhotoPage(){

            Component compoment = MapIcon.ObjReference as Component;

            await Navigation.PushAsync(new PhotoPage(compoment));
        }

        void Photo_Tapped(object sender, System.EventArgs e)
        {
            OnCallPhotoPage();
        }
    }
}
