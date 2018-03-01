using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo.Pages
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
    }
}