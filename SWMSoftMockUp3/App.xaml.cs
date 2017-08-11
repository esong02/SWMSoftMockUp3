using Xamarin.Forms;
using SWMSoftMockUp3.Views;
using SWMSoftMockUp3.Views.Templates;
using SWMSoftMockUp3.Views.AssetOrder;

namespace SWMSoftMockUp3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //MainPage = new ServerPage();
            //MainPage = new HomePage();
            MainPage = new NavigationPage(new ServerPage());
            //MainPage = new NavigationPage(new LoginServerPage());
            //MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
