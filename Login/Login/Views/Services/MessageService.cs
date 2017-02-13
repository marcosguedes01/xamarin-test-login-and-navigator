using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Views.Services
{
    public class MessageService : ViewModels.Services.IMessageService
    {
        public Task ShowAsync(string message)
        {
            return App.Current.MainPage.DisplayAlert("Login Test", message, "ok");
        }
    }
}
