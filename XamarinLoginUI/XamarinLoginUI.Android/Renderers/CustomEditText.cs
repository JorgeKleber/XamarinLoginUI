using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinLoginUI.Droid.Renderers;
using XamarinLoginUI.UI.Renderers;

[assembly:ExportRenderer(typeof(PersonalEntry), typeof(CustomEditText))]
namespace XamarinLoginUI.Droid.Renderers
{
	public class CustomEditText : EntryRenderer
	{
		public CustomEditText(Context context) : base(context)
		{
		}

		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
				Control.Background = Context.GetDrawable(Resource.Drawable.border_shape);
			}
		}
	}
}