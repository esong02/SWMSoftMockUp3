using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SWMSoftMockUp3.Views.Templates
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AssetOrder : ContentPage
	{
		public AssetOrder ()
		{
			InitializeComponent();
            //AssetOrder.ItemsSource = assetVM.assetList;
        }
	}
}