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
    public partial class MaintenancePage : ContentPage
    {
        public MaintenancePage()
        {
            InitializeComponent();
        }

        private void SendMaintenanceNote_Clicked(object sender, EventArgs e)
        {
            MaintenanceDialogScreen.IsVisible = true;
        }

        void CommentCancel_Clicked(object sender, System.EventArgs e)
        {

            MaintenanceDialogScreen.IsVisible = false;
        }

        void CommentSave_Clicked(object sender, System.EventArgs e)
        {

            MaintenanceDialogScreen.IsVisible = false;
        }

        void CloseDialog_Tapped(object sender, System.EventArgs e)
        {

            MaintenanceDialogScreen.IsVisible = false;
        }

    }
}