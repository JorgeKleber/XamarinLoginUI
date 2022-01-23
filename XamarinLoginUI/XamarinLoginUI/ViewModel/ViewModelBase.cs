using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace XamarinLoginUI.ViewModel
{
	class ViewModelBase : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public void Notify(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public async void ModalNavigation(Page page, bool isAnimated)
		{
			await App.Current.MainPage.Navigation.PushModalAsync(page, isAnimated);
		}
	}
}