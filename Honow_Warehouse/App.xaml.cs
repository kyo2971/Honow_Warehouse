using Honow_Warehouse.Models;

namespace Honow_Warehouse;

public partial class App : Application
{
	public static UserInfo UserInfo;
	public App()
	{
		InitializeComponent();

        MainPage = new AppShell(); //LoginPage
        //MainPage = new NavigationPage(new Login2Page()); //Login2Page
    }
}

//https://www.youtube.com/watch?v=P8wc4lFngXk
//https://www.youtube.com/watch?v=zK82egxHrLc
