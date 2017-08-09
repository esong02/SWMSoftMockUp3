using System;

using Xamarin.Forms;

namespace SWMSoftMockUp3.CustomControls
{
    public class ListButton : Button
    {
		public static readonly BindableProperty ObjReferenceProperty = BindableProperty.Create("ObjReference", typeof(object), typeof(ListButton), null);

		public object ObjReference
		{
			get { return (object)GetValue(ObjReferenceProperty); }
			set { SetValue(ObjReferenceProperty, value); }
		}
    }
}
