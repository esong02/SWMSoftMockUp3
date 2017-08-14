using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SWMSoftMockUp3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PhotoGallery : ContentPage
    {
        public PhotoGallery()
        {
            InitializeComponent();
        }

        private void EditButton_Clicked(object sender, EventArgs e)
        {
            CommentDialogScreen.IsVisible = true;
        }

        private void CommentCancel_Clicked(object sender, EventArgs e)
        {
            CommentDialogScreen.IsVisible = false;
        }

        private void CommentSave_Clicked(object sender, EventArgs e)
        {
            CommentDialogScreen.IsVisible = false;
        }

        void CloseDialog_Tapped(object sender, System.EventArgs e)
        {
            CommentDialogScreen.IsVisible = false;
        }

    }
}