using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SWMSoftMockUp3.Views.AssetOrder
{
    public partial class HomePage : ContentPage
    {

        List<string> _assetList = new List<string>
        {
            "Start",
            "Hello",
            "Hi",
            "Bye",
            "GoodBye",
            "End"
        };

        public HomePage()
        {
            InitializeComponent();
        }
    }
}
