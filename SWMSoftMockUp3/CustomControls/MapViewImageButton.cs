using System;
using Xamarin.Forms;

namespace SWMSoftMockUp3.CustomControls
{
    public class MapViewImage : Image
    {
        
		public static readonly BindableProperty InspectionIDProperty = BindableProperty.Create("InspectionID", typeof(int), typeof(MapViewImage), 0);

		public int InspectionID
		{
			get { return (int)GetValue(InspectionIDProperty); }
			set { SetValue(InspectionIDProperty, value); }
		}

		public static readonly BindableProperty InspectionAddressProperty = BindableProperty.Create("InspectionAddress", typeof(string), typeof(MapViewImage), "");

		public string InspectionAddress
		{
			get { return (string)GetValue(InspectionAddressProperty); }
			set { SetValue(InspectionIDProperty, value); }
		}

	}
}
