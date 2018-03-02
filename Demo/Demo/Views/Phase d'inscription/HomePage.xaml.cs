using System;
using Rg.Plugins.Popup.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
	    private Pages.LoginPopupPage _connexionMembre;
		public HomePage ()
		{
			InitializeComponent ();
            _connexionMembre = new Pages.LoginPopupPage();
		}

	    private async void Button_OnClicked(object sender, EventArgs e)
	    {
	       // var answer = await DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");
            await Navigation.PushModalAsync(new Inscription());
	    }

	    private async void Cnx(object sender, EventArgs e)
	    {
	        await Navigation.PushPopupAsync(_connexionMembre);
        }

	   
	}
}