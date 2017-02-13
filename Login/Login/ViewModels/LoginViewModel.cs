using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Login.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                this.Notify(nameof(Email));
            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                this.Notify(nameof(Password));
            }
        }

        private readonly Services.IMessageService _messageService;
        private readonly Services.INavigatorService _navigateService;
        public LoginViewModel()
        {
            this.LoginCommand = new Command(this.Login);
            this.RegisterCommand = new Command(this.Register);

            this._messageService = DependencyService.Get<Services.IMessageService>();
            this._navigateService = DependencyService.Get<Services.INavigatorService>();
        }

        public ICommand LoginCommand
        {
            get; set;
        }

        public ICommand RegisterCommand
        {
            get; set;
        }

        private async void Login()
        {
            if (this.email == "adm" && this.password == "123")
            {
                // Navegar para a MainView
                await this._navigateService.NavigateToMain();
            }
            else
            {
                // Emitir mensagem de erro
                await this._messageService.ShowAsync("Email ou senha inválida.");
            }
        }
        private async void Register() {
            await this._navigateService.NavigateToRegister();
        }
    }
}
