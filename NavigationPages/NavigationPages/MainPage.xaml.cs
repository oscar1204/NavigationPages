using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavigationPages
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            

		}
        public async void SiguieteButton_Clicked(Object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Pagina2());
        }
	}
}
