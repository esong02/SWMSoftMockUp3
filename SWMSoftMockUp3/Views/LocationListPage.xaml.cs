using System;
using System.Collections.Generic;

using Xamarin.Forms;
using SWMSoftMockUp3.ViewModels;

namespace SWMSoftMockUp3.Views
{
    public partial class LocationListPage : ContentPage
    {
        void InspectionType_Clicked(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }

        AssetLocationVM _aLVM;

        public LocationListPage(string userName)
        {
            InitializeComponent();
            //Title = Title + "\t" + userName;
            _aLVM = new AssetLocationVM();
            AssetLocationList.ItemsSource = _aLVM._assetLocations;

        }
    }
}
