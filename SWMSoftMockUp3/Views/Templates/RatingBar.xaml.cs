using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SWMSoftMockUp3.Views.Templates
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RatingBar : ContentView
    {
        public RatingBar()
        {
            InitializeComponent();
        }

        private void Reset_Tapped(object sender, EventArgs e)
        {
            Rate1.Source = "StarUnselected.png";
            Rate2.Source = "StarUnselected.png";
            Rate3.Source = "StarUnselected.png";
            Rate4.Source = "StarUnselected.png";
            Rate5.Source = "StarUnselected.png";
        }

        private void Rating_Tapped(object sender, EventArgs e)
        {
            var rating = sender as Image;
            if (rating.Equals(Rate1))
            {
                Rate1.Source = "StarSelected.png";
                Rate2.Source = "StarUnselected.png";
                Rate3.Source = "StarUnselected.png";
                Rate4.Source = "StarUnselected.png";
                Rate5.Source = "StarUnselected.png";
            }
            else if (rating.Equals(Rate2))
            {
                Rate1.Source = "StarSelected.png";
                Rate2.Source = "StarSelected.png";
                Rate3.Source = "StarUnselected.png";
                Rate4.Source = "StarUnselected.png";
                Rate5.Source = "StarUnselected.png";
            }
            else if (rating.Equals(Rate3))
            {
                Rate1.Source = "StarSelected.png";
                Rate2.Source = "StarSelected.png";
                Rate3.Source = "StarSelected.png";
                Rate4.Source = "StarUnselected.png";
                Rate5.Source = "StarUnselected.png";
            }
            else if (rating.Equals(Rate4))
            {
                Rate1.Source = "StarSelected.png";
                Rate2.Source = "StarSelected.png";
                Rate3.Source = "StarSelected.png";
                Rate4.Source = "StarSelected.png";
                Rate5.Source = "StarUnselected.png";
            }
            else if (rating.Equals(Rate5))
            {
                Rate1.Source = "StarSelected.png";
                Rate2.Source = "StarSelected.png";
                Rate3.Source = "StarSelected.png";
                Rate4.Source = "StarSelected.png";
                Rate5.Source = "StarSelected.png";
            }

        }
    }
}