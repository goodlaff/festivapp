using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Xamarin.Forms.Platform.Android;


namespace Festivapp.Android
{
	[Activity (Label = "Festivapp", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)] //, Theme = "@android:style/Theme.NoTitleBar")]
	public class MainActivity : AndroidActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			Xamarin.Forms.Forms.Init (this, bundle);

			SetPage (App.GetMainPage ());

			//Window.SetFeatureInt(WindowFeatures.CustomTitle, Resource.Layout.CustomTitleBar);
		}
	}
}

