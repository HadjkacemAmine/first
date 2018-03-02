using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo.Views 
{ 
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FrameView : Frame
	{
		public FrameView ()
		{
			InitializeComponent ();
		}
	}
}