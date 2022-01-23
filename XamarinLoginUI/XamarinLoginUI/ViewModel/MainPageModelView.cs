using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinLoginUI.ViewModel
{
	class MainPageModelView : ViewModelBase
	{

		private string _Email;

		public string Email
		{
			get => _Email;
			set
			{
				_Email = value;
				Notify("Email");
			}
		}

		public ICommand loginCommand { get; set; }
		public ICommand fogetPasswordCommand { get; set; }
		public ICommand createAccountCommand { get; set; }

		public MainPageModelView()
		{
			loginCommand = new Command(LoginButton_Event);
			fogetPasswordCommand = new Command(FogetPass_Event);
			createAccountCommand = new Command(CreateAccount_Event);
		}

		private void LoginButton_Event(object obj)
		{
			throw new NotImplementedException();
		}

		private void FogetPass_Event(object obj)
		{
			throw new NotImplementedException();
		}

		private void CreateAccount_Event(object obj)
		{
			throw new NotImplementedException();
		}
	}
}
