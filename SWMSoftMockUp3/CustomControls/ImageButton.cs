using System;

using Xamarin.Forms;

namespace SWMSoftMockUp3.CustomControls
{
    public class ImageButton : Image
    {
		public static readonly BindableProperty ItemObjectProperty = BindableProperty.Create("ItemObject", typeof(object), typeof(ImageButton), null);

		public object ItemObject
		{
			get { return (object)GetValue(ItemObjectProperty); }
			set { SetValue(ItemObjectProperty, value); }
		}

	}
}
