using ApothecaryManager.Data.Model;
using ApothecaryManager.WPF.Helpers;
using ApothecaryManager.WPF.Services.Interfaces;
using ApothecaryManager.WPF.ViewModels;
using Catel.IoC;
using Catel.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApothecaryManager.WPF.Services
{
    class SessionService : ISessionService
    {
        readonly ApiHelper api;

        public SessionService(ApiHelper api)
        {
            this.api = api;
        }

        int userId { get; set; }
        string RefreshToken { get; set; }
        string AccessToken { get; set; }

        public bool LoggedIn => throw new NotImplementedException();
        public DateTime LoginTimestamp => throw new NotImplementedException();
        public User LoggedUser => throw new NotImplementedException();

        public async Task<bool> ShowDialogAsync()
        {
            var serviceLocator = ServiceLocator.Default;
            var visualizerService = serviceLocator.ResolveType<UIVisualizerService>();
            var result = await visualizerService.ShowAsync<LoginViewModel>(null);

            return result.GetValueOrDefault();
        }

        public bool Login(string username, string password)
        {
            var result = api.Authenticate(username, password).Result;

            if (result != null)
            {
                userId = result.userId;
                RefreshToken = result.RefreshToken;
                AccessToken = result.AccessToken;
                return true;
            }
            else
                return false;
        }

        public bool Logout()
        {
            throw new NotImplementedException();
        }

        public bool Refresh()
        {
            throw new NotImplementedException();
        }

        public void Setup()
        {

        }
    }
}
