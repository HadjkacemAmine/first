using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProfilView : ContentView
	{
		public ProfilView ()
		{
			InitializeComponent ();
            
		}

	    private async void Button_OnClicked(object sender, EventArgs e)
	    {
	       // var answer = await DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");


        }
    }
}