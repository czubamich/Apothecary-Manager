namespace ApothecaryManager.WPF.ViewModels
{
    using Catel.MVVM;
    using System.Threading.Tasks;
    using System.Collections.ObjectModel;
    using System.Linq;
    using Catel;
    using Catel.Collections;
    using Catel.Data;
    using Catel.IoC;
    using Catel.Services;
    using ApothecaryManager.WPF.Services.Interfaces;
    using System;

    public class LoginViewModel : ViewModelBase
    {

        public override string Title { get { return "Apothecary Manager - Login"; } }

        public string Password
        {
            get { return GetValue<string>(PasswordProperty); }
            set { SetValue(PasswordProperty, value); }
        }

        public string Username
        {
            get { return GetValue<string>(UsernameProperty); }
            set { SetValue(UsernameProperty, value); }
        }


        public string ErrorText
        {
            get { return GetValue<string>(ErrorTextProperty); }
            set { SetValue(ErrorTextProperty, value); }
        }

        public static readonly PropertyData ErrorTextProperty = RegisterProperty(nameof(ErrorText), typeof(string), "");
        public static readonly PropertyData UsernameProperty = RegisterProperty(nameof(Username), typeof(string), "");
        public static readonly PropertyData PasswordProperty = RegisterProperty(nameof(Password), typeof(string), "");

        public Command LoginCommand { get; private set; }
        public ISessionService SessionService { get; }

        public LoginViewModel(ISessionService sessionService)
        {
            LoginCommand = new Command(OnLoginCommandExecute, OnLoginCommandCanExecute);
            SessionService = sessionService;
        }

        private bool OnLoginCommandCanExecute()
        {
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                return false;
            }
            else
                return true;
        }

        private async void OnLoginCommandExecute()
        {
            try
            {
                var result = SessionService.Login(Username, Password);
                if(result)
                    this.CloseViewModelAsync(true);
            }
            catch(Exception e)
            {
                ErrorText = e.Message;
            }
        }

        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();

            // TODO: subscribe to events here
        }

        protected override async Task CloseAsync()
        {
            // TODO: unsubscribe from events here

            await base.CloseAsync();
        }
    }
}
