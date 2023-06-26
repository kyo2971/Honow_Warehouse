namespace Honow_Warehouse.UserControl;

public partial class FlyoutHeaderControl : ContentView
{
	public FlyoutHeaderControl()
	{
		InitializeComponent();
		if (App.UserInfo != null)
		{ 
			lblUserName.Text ="Logged in as :"+ App.UserInfo.UserName;
			lblUsereMail.Text = App.UserInfo.UserName;// Set Email From API
		}
	}
}