using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using Pages;
using MonoTouch.UIKit;

[assembly: ExportRenderer (typeof(CustomNavigationPage), typeof(NavigationPageRenderer))]

namespace Pages
{
	public class NavigationPageRenderer : NavigationRenderer
	{
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			NavigationBar.Translucent = true;
			NavigationBar.BarStyle = UIBarStyle.Black;
			HidesBarsOnTap = true;
		}
	}
}

