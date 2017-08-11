using System;
using System.Collections.Generic;

using Xamarin.Forms;

using SWMSoftMockUp3.Models;

namespace SWMSoftMockUp3.Views
{
    public partial class PhotoPage : ContentPage
    {
        public PhotoPage(Component component)
        {
            InitializeComponent();
            Title = component.Name;
        }

        void AddNote_Tapped(object sender, System.EventArgs e)
        {
            CommentDialogScreen.IsVisible = true;
        }

		void AddPhoto_Tapped(object sender, System.EventArgs e)
		{
			//CommentDialogScreen.IsVisible = true;
		}

		void Gallery_Tapped(object sender, System.EventArgs e)
		{
			//CommentDialogScreen.IsVisible = true;
		}

        void CloseDialog_Tapped(object sender, System.EventArgs e)
        {
            CommentDialogScreen.IsVisible = false;
        }

        void CommentCancel_Clicked(object sender, System.EventArgs e)
        {
            CommentDialogScreen.IsVisible = false;
        }

		void CommentSave_Clicked(object sender, System.EventArgs e)
		{
			CommentDialogScreen.IsVisible = false;
		}
    }
}
