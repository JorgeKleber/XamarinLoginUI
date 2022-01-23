using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinLoginUI.View;

namespace XamarinLoginUI.ViewModel
{
	class WelcomePageViewModel : ViewModelBase
	{
		public ICommand StartButton { get; set; }

		public WelcomePageViewModel()
		{
			StartButton = new Command(StartButtonEvent);
		}

		private void StartButtonEvent(object obj)
		{
			ModalNavigation(new MainPage(),true);
		}
	}
}
