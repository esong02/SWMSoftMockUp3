using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SWMSoftMockUp3.Views
{
    public partial class ServerPage : ContentPage
    {
        public static string serverID;

        public ServerPage()
        {
            InitializeComponent();
        }

		void Connect_Clicked(object sender, System.EventArgs e)
		{
            var connectBtn = sender as Button;
            serverID = ServerText.Text;

            if(ConnectToServer(serverID)){
                OnCallLoginPage();
            }else{
                ServerText.Text = "Cannot Connect";
            }
		}

        bool ConnectToServer(string serverURL){
            //if connection works return true

            return true;
        }

        async void OnCallLoginPage(){
            await Navigation.PushAsync(new LoginPage());
        }

    }
}
