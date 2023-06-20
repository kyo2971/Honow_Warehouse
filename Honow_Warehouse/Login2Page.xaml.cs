using Honow_Warehouse.Pages;

namespace Honow_Warehouse;

public partial class Login2Page : ContentPage
{
	public Login2Page()
	{
		InitializeComponent();
	}

    private async void btnLogin_Clicked(object sender, EventArgs e)
    {
		string userName= txtUserName.Text;
		string password= txtPassword.Text;

		if (userName == null || password == null)
		{
			await DisplayAlert("Warning", "Please input UserName & Password.", "OK");
			return;
		}
		else
		{
			if (userName == "00813" && password == "00813")
			{ await Navigation.PushAsync(new Home2Page()); }
			else 
			{ await DisplayAlert("Warning", "UserName or Password is incorrect.", "OK"); }
		}
    }
}