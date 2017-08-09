using System;

using Xamarin.Forms;

namespace SWMSoftMockUp3.CustomControls
{
    public class ImageButton : Image
    {
		public static readonly BindableProperty ObjReferenceProperty = BindableProperty.Create("ObjReference", typeof(object), typeof(ImageButton), null);

        public object ObjReference
		{
			get { return (object)GetValue(ObjReferenceProperty); }
			set { SetValue(ObjReferenceProperty, value); }
		}

	}
}
