using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinLoginUI.View;

[assembly: ExportFont("OpenSans-Regular.ttf",Alias ="CustomFont")]
[assembly: ExportFont("MarckScript-Regular.ttf", Alias ="CustomFont2")]
namespace XamarinLoginUI
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new WelcomePage();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
