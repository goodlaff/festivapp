using System;
using Xamarin.Forms;
using Pages;
using Xamarin.Forms.Platform.Android;
using Android.App;
using Android.Views;
using Android.Graphics.Drawables;
using System.Collections.Generic;
using Android.Graphics;

[assembly: ExportRenderer (typeof(CustomNavigationPage), typeof(NavigationPageRenderer))]

namespace Pages
{
	public class NavigationPageRenderer : NavigationRenderer
	{
	}
}

