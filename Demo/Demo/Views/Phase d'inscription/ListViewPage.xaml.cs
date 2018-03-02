using System;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;

namespace Demo.Views
{
    public partial class ListViewPage : PopupPage
    {
        public ListViewPage()
        {
            InitializeComponent();
           
        }

        private async void OnClose(object sender, EventArgs e)
        {
            await Navigation.PopPopupAsync();
        }
    }
}
