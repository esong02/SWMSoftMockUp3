using Xamarin.Forms;

namespace ServerClient
{
    public class ServerClient : ContentPage
    {
        public ServerClient()
        {
            var button = new Button
            {
                Text = "Click Me!",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            var clicked = 0;
            button.Clicked += (s, e) => button.Text = "Clicked: " + clicked++;

            Content = button;
        }
    }
}