using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Views.Services
{
    class NavigateService : ViewModels.Services.INavigatorService
    {
        public async Task NavigateToLogin()
        {
            await App.Current.MainPage.Navigation.PushAsync(new Views.LoginView());
        }

        public async Task NavigateToMain()
        {
            await App.Current.MainPage.Navigation.PushAsync(new Views.MainView());
        }

        public async Task NavigateToRegister()
        {
            await App.Current.MainPage.Navigation.PushAsync(new Views.RegisterView());
        }
    }
}
