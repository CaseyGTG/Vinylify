using Vinylify.Pages;

namespace Vinylify;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		Navigation.PushAsync(new LogIn());
    }
}

