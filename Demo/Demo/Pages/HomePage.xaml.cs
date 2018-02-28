using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
	    private LoginPopupPage _connexionMembre;
		public HomePage ()
		{
			InitializeComponent ();
            _connexionMembre = new LoginPopupPage();
		}

	    private async void Button_OnClicked(object sender, EventArgs e)
	    {
	        await Navigation.PushAsync(new Inscription());
	    }

	    private async void Cnx(object sender, EventArgs e)
	    {
	        await Navigation.PushPopupAsync(_connexionMembre);
        }

	   
	}
}