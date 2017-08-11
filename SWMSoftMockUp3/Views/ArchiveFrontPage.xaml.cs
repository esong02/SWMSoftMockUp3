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
    public partial class ArchiveFrontPage : ContentPage
    {
        public ArchiveFrontPage()
        {
            InitializeComponent();
        }

        async void OnCallArchiveBackPage()
        {
            await Navigation.PushAsync(new ArchiveBackPage());
        }

        private void TodayDate_Clicked(object sender, EventArgs e)
        {
            OnCallArchiveBackPage();
        }
    }
}