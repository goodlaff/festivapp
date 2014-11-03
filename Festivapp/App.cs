using System;
using Xamarin.Forms;
using Pages;

namespace Festivapp
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			return new CustomNavigationPage (new HomePage ());
		}
	}
}

