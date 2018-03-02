using System;
using Demo.Views;

using Rg.Plugins.Popup.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inscription : TabbedPage
    {
        public Inscription ()
        {
            InitializeComponent();
           
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            var answer = await DisplayAlert("", "Siége et Usine ont les mêmes Coordonnées ?", "Oui", "Non");
            if (answer.Equals(true))
            {
                var page = new ListViewPage();
                await Navigation.PushPopupAsync(page);
            }

        }
        
        private async void Button_OnClicked1(object sender, EventArgs e)
        {
           DisplayAlert("Confirmation d'inscription" , "votre demande d\'inscription a été envoyé à la chambre\r\n    " +
                                                              "            de commerce en question\r\n         " +
                                                              "       Vous pouvez suivre l\'état d\'avancement du traitement de celle - ci à travers votre espace personnel.\r\n        " +
                                                              "        Un mail Contenant vos identifiants a été envoyé afin d\'activer votre session sur le portail infocham \r\n   " +
                                                              "             Merci Pour votre confiance.","FERMER");
           
                await Navigation.PushModalAsync(new MasterDetailHome());
            
        }
    }
}