using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace GeoChat.XamarinForms
{	
	public partial class Start : ContentPage
	{	
		public Start ()
		{
			InitializeComponent ();
		}

		public void back_Clicked(object sender, EventArgs ea)
		{
			this.Navigation.PushAsync (new MainPage ());
		}
	}
}

