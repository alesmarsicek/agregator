using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Agregator.Droid
{
	[Activity (Label = "Agregator", Icon = "@drawable/icon", Theme="@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar; 

			base.OnCreate (bundle);
            App.width = (int)Resources.DisplayMetrics.WidthPixels; // real pixels
            App.height = (int)Resources.DisplayMetrics.HeightPixels;
            global::Xamarin.Forms.Forms.Init (this, bundle);
			LoadApplication (new Agregator.App ());
		}
	}
}

