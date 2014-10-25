using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace GeoChat.XamarinForms
{	
	public partial class MainPage : TabbedPage
	{	
		public MainPage ()
		{
			InitializeComponent ();
		}


        public void earthChat_Clicked(object sender, EventArgs ea)
		{
			this.Navigation.PushAsync (new EarthChat ());

		}
        public void nearby_Clicked(object sender, EventArgs ea)
        {
			this.Navigation.PushAsync (new Nearby ());
        }

        public void start_Clicked(object sender, EventArgs ea)
        {
			this.Navigation.PushAsync (new Start());
        }
	}
}

