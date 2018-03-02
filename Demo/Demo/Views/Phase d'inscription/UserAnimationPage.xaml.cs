using System;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;

namespace Demo.Views
{
    public partial class UserAnimationPage : PopupPage
    {
        public UserAnimationPage()
        {
            InitializeComponent();
        }

        private void OnClose(object sender, EventArgs e)
        {
            PopupNavigation.PopAsync();
        }
    }
}
