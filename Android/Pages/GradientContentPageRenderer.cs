using System;
using Xamarin.Forms;
using Pages;
using Xamarin.Forms.Platform.Android;
using Android.App;
using Android.Views;
using Android.Graphics;
using Android.Graphics.Drawables;
using System.Collections.Generic;

[assembly: ExportRenderer (typeof(GradientContentPage), typeof(GradientContentPageRenderer))]

namespace Pages
{
	public class GradientContentPageRenderer : PageRenderer
	{
		public override bool OnTouchEvent (MotionEvent e)
		{
			// only execute on up action
			if (e.Action == MotionEventActions.Up) {
				// get activity
				var activity = this.Context as Activity;

				// hide/show action and status bars
				if (activity.ActionBar.IsShowing) {
					activity.ActionBar.Hide ();
					SystemUiVisibility = StatusBarVisibility.Hidden;
				} else {
					activity.ActionBar.Show ();
					SystemUiVisibility = StatusBarVisibility.Visible;
				}
			}

			return base.OnTouchEvent (e);
		}

		/*
		 *  Both draw on canvas and drawable work, have opted for the more specific SetBackgroundDrawable
		 */


		//		protected override void OnDraw (Android.Graphics.Canvas canvas)
		//		{
		//			base.OnDraw (canvas);
		//			Paint p = new Paint ();
		//
		//			var page = Element as GradientContentPage;
		//
		//			p.SetShader (new LinearGradient (Convert.ToInt16 (this.Width * 0.4), Convert.ToInt16 (this.Height * -0.4), Convert.ToInt16 (this.Width * 0.7), Convert.ToInt16 (this.Height * 0.6), page.StartColor.ToAndroid (), page.EndColor.ToAndroid (), Shader.TileMode.Clamp));
		//			p.Dither = true;
		//			canvas.DrawPaint (p);
		//		}

		public override void SetBackgroundDrawable (Drawable background)
		{
			var page = Element as GradientContentPage;

			var colors = new List<int> ();
			colors.Add (page.StartColor.ToAndroid ());
			colors.Add (page.EndColor.ToAndroid ());

			GradientDrawable gradient = new GradientDrawable (GradientDrawable.Orientation.TlBr, colors.ToArray ());
			gradient.SetGradientType (GradientType.LinearGradient);
			gradient.SetDither (true);
			gradient.Bounds = background.Bounds;

			base.SetBackgroundDrawable (gradient);
		}
	}
}

