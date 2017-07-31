
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace SWMSoftMockUp3.Droid.Assets
{
    [Activity(Label = "SWMSoft", Icon = "@drawable/icon", Theme = "@style/splashscreen", MainLauncher = false, NoHistory = true)]
    public class SplashActivity : AppCompatActivity
    {
		protected override void OnResume()
		{
			base.OnResume();
			StartActivity(typeof(MainActivity));
		}
    }
}
