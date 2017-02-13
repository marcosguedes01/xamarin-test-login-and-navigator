using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Login.ViewModels
{
    public class MainViewModel
    {
        public ICommand RegisterCommand
        {
            get; set;
        }

        private readonly Services.IMessageService _messageService;
        private readonly Services.INavigatorService _navigateService;
        public MainViewModel()
        {
            this.RegisterCommand = new Command(this.Register);

            this._messageService = DependencyService.Get<Services.IMessageService>();
            this._navigateService = DependencyService.Get<Services.INavigatorService>();
        }

        private async void Register()
        {
            await this._messageService.ShowAsync("Vou para a RegisterView");
            await this._navigateService.NavigateToRegister();
        }
    }
}
