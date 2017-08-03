using System;
using Xamarin.Forms;
using SWMSoftMockUp3.Models;

namespace SWMSoftMockUp3.CustomControls
{
    public class InspectionTypeButton : Button
    {
        public static readonly BindableProperty InspectionTypeProperty = BindableProperty.Create("InspectionType", typeof(string), typeof(InspectionTypeButton), "");

		public string InspectionType
		{
			get { return (string)GetValue(InspectionTypeProperty); }
			set { SetValue(InspectionTypeProperty, value); }
		}

		public static readonly BindableProperty InspectionIDProperty = BindableProperty.Create("InspectionID", typeof(int), typeof(InspectionTypeButton), 0);

		public int InspectionID
		{
			get { return (int)GetValue(InspectionIDProperty); }
			set { SetValue(InspectionIDProperty, value); }
		}

		public static readonly BindableProperty InspectionAddressProperty = BindableProperty.Create("InspectionArea", typeof(string), typeof(InspectionTypeButton), "");

		public string InspectionAddress
		{
			get { return (string)GetValue(InspectionAddressProperty); }
			set { SetValue(InspectionIDProperty, value); }
		}

		public static readonly BindableProperty AssetLocationObjectProperty = BindableProperty.Create("AssetLocationObject", typeof(AssetLocation), typeof(InspectionTypeButton), null);

		public AssetLocation AssetLocationObject
		{
			get { return (AssetLocation)GetValue(AssetLocationObjectProperty); }
			set { SetValue(AssetLocationObjectProperty, value); }
		}

    }
}
