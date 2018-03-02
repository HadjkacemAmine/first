using System;
using Plugin.FilePicker;
using Plugin.FilePicker.Abstractions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PiécesJustificatifsView : ContentView
	{
	    public FileData file = null;
	    public FileData filea = null;


        public PiécesJustificatifsView ()
		{
			InitializeComponent ();
		    btnAnnuler.IsVisible = false;
		    btnCh.IsVisible = true;
		    btnAnnulera.IsVisible = false;
		    btnCha.IsVisible = true;
        }

	    private async void Button_OnClicked(object sender, EventArgs e)
	    {
	        file = await CrossFilePicker.Current.PickFile();
	        if (file!= null)
	        {
	            RegistreLabel.Text = file.FileName;
	            btnAnnuler.IsVisible = true;
	            btnCh.IsVisible = false;
	        }
	    }

	    private void BtnAnnuler_OnClicked(object sender, EventArgs e)
	    {
	        file = null;
	        btnAnnuler.IsVisible = false;
	        btnCh.IsVisible = true;
	        RegistreLabel.Text = "Aucun fichier choisi";
	    }


	    private void BtnAnnulera_OnClicked(object sender, EventArgs e)
	    {
	        filea = null;
	        btnAnnulera.IsVisible = false;
	        btnCha.IsVisible = true;
	        RegistreLabela.Text = "Aucun fichier choisi";
	    }

	    private async void BtnCha_OnClicked(object sender, EventArgs e)
	    {
	        filea = await CrossFilePicker.Current.PickFile();
	        if (filea != null)
	        {
	            RegistreLabela.Text = filea.FileName;
	            btnAnnulera.IsVisible = true;
	            btnCha.IsVisible = false;
	        }
	    }
	}
}