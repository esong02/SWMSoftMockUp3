using System;
using System.Collections.Generic;

using SWMSoftMockUp3.CustomControls;
using SWMSoftMockUp3.Models;

using Xamarin.Forms;

namespace SWMSoftMockUp3.Views
{
    public partial class TaskPage : ContentPage
    {

        Component selectedComponent;

        public TaskPage(Component selectedComponent)
        {
            InitializeComponent();
            Title = selectedComponent.Name;
            this.selectedComponent = selectedComponent;
        }



        async void OnCallPhotoPage()
        {
            await Navigation.PushAsync(new PhotoPage(selectedComponent));
        }

        void Photo_Tapped(object sender, System.EventArgs e)
        {
            OnCallPhotoPage();
        }
    }
}
