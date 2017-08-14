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

        async void OnCallGalleryPage()
        {
            await Navigation.PushAsync(new PhotoGallery());
        }

        void Gallery_Tapped(object sender, System.EventArgs e)
		{
            OnCallGalleryPage();
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

        private void CancelZoom_Tapped(object sender, EventArgs e)
        {
            ZoomedImageScreen.IsVisible = false;
        }

        private void ZoomImage_Tapped(object sender, EventArgs e)
        {
            ZoomedImageScreen.IsVisible = true;
        }

    }
}
