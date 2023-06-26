using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Honow_Warehouse.Models;
using Honow_Warehouse.Service;
using Honow_Warehouse.UserControl;
using Honow_Warehouse.Views;
using Newtonsoft.Json;

namespace Honow_Warehouse.ViewModels
{
    public partial class LoginPageViewModel: BaseViewModel
    {
        [ObservableProperty]
        private string _userName;
        [ObservableProperty]
        private string _password;

        readonly ILoginRepository loginRepository= new LoginService();

        [RelayCommand]
        public async void Login()
        {
            //await Shell.Current.DisplayAlert("Error, no Maps app!", UserName+"/"+Password, "OK");
            if (!string.IsNullOrWhiteSpace(UserName) && !string.IsNullOrWhiteSpace(Password))
            {
                UserInfo userInfo = await loginRepository.Login(UserName, Password);

                if (Preferences.ContainsKey(nameof(App.UserInfo)))
                { Preferences.Remove(nameof(App.UserInfo)); }

                string userDetails = JsonConvert.SerializeObject(userInfo);
                Preferences.Set(nameof(App.UserInfo), userDetails);
                App.UserInfo = userInfo;

                AppShell.Current.FlyoutHeader = new FlyoutHeaderControl();

                await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
            }
        }
    }
}
