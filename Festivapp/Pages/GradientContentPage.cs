using Xamarin.Forms;

namespace Pages
{
	public class GradientContentPage : ContentPage
	{
		public Color StartColor { get; set; }

		public Color EndColor { get; set; }

		public GradientContentPage ()
		{
			BackgroundColor = Color.FromRgb (150, 187, 187);

		}
	}
}

