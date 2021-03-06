﻿﻿﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;
using SWMSoftMockUp3.ViewModels;
using SWMSoftMockUp3.Models;
using SWMSoftMockUp3.CustomControls;

namespace SWMSoftMockUp3.Views
{
    public partial class LocationListPage : ContentPage
    {
        AssetLocationVM _aLVM;

		//Constructor. This creates the Location list Page.
		public LocationListPage(string userName)
		{
			InitializeComponent();
			//var navPage = Application.Current.MainPage as NavigationPage;
			//navPage.BarBackgroundColor = Color.White;
			//navPage.BarTextColor = Color.Black;
			_aLVM = new AssetLocationVM();
            
			AssetLocationList.ItemsSource = _aLVM._assetLocations;

		}

        //Used to disable Highlight Selection, since the feature is not used
        void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
			if (e == null) return; // has been set to null, do not 'process' tapped event      
            ((ListView)sender).SelectedItem = null; // de-select the row         }
		}

        async void OnCallLocationMapPage(object itemObject){
            await Navigation.PushAsync(new LocationMapPage(itemObject));
        }

        void MapView_Tapped(object sender, System.EventArgs e)
        {

            var item = sender as ImageButton;

            OnCallLocationMapPage(item.ObjReference);
        }


		async void OnCallAssetListPage(object location)
		{
            /*
            if (location != null){
                
            }
            */

            var aLocation = location as AssetLocation;

			await Navigation.PushAsync(new AssetListPage(_aLVM,aLocation));
		}

		void InspectionType_Clicked(object sender, System.EventArgs e)
		//-------------------------------------------------------------
		{
			var item = sender as InspectionTypeButton;

            OnCallAssetListPage(item.ObjReference);
		}



    }

}
