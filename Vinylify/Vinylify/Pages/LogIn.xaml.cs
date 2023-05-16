using System.Diagnostics;

namespace Vinylify.Pages;

public partial class LogIn : ContentPage
{
	public LogIn()
	{
		InitializeComponent();
	}

    private void Login_Button_Clicked(System.Object sender, System.EventArgs e)
    {
		Trace.WriteLine("Logging in my guy");
    }
}