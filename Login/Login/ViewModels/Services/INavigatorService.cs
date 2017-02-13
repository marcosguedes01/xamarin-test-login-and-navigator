using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.ViewModels.Services
{
    public interface INavigatorService
    {
        Task NavigateToLogin();
        Task NavigateToRegister();
        Task NavigateToMain();
    }
}
