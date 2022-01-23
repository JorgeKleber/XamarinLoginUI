using Android.App;
using Android.Content;
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

[assembly:ExportRenderer(typeof(PersonalButton),typeof(CustomButton))]
namespace XamarinLoginUI.Droid.Renderers
{
	class CustomButton : ButtonRenderer
	{
		public CustomButton(Context context) : base(context)
		{
		}

		protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
		{
			base.OnElementChanged(e);

			Control.Background = Context.GetDrawable(Resource.Drawable.button_border_shape);
			Control.Elevation = 12f;
		}
	}
}