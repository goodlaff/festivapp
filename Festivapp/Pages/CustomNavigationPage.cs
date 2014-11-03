using System;
using Xamarin.Forms;

namespace Pages
{
	public class CustomNavigationPage : NavigationPage
	{
		public CustomNavigationPage (Page page) : base (page)
		{
			BarBackgroundColor = Color.FromRgb (131, 173, 177);
//			BackgroundColor = Color.FromRgb (150, 187, 187);
		}
	}
}

