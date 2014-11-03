using System;
using System.Collections.Generic;
using System.Drawing;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreGraphics;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Pages;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer (typeof(GradientContentPage), typeof(GradientContentPageRenderer))]

namespace Pages
{
	public class GradientContentPageRenderer : PageRenderer
	{
		protected override void OnElementChanged (VisualElementChangedEventArgs e)
		{
			base.OnElementChanged (e);

			if (e.OldElement == null) { 
				var page = e.NewElement as GradientContentPage;

				// only apply gradient to top 60% of page
				var locations = new List<NSNumber> ();
				locations.Add (NSNumber.FromFloat (0.0f));
				locations.Add (NSNumber.FromFloat (0.6f));

				var gradientLayer = new CAGradientLayer ();
				gradientLayer.Frame = View.Bounds;
				// set start point as slightly to left of centre and above page
				gradientLayer.StartPoint = new PointF (0.4f, -0.2f);
				gradientLayer.EndPoint = new PointF (0.7f, 0.7f);
				gradientLayer.Locations = locations.ToArray ();
				gradientLayer.Colors = new CGColor[] { page.StartColor.ToCGColor (), page.EndColor.ToCGColor () };

				View.Layer.InsertSublayer (gradientLayer, 0);
			}
		}
	}
}

