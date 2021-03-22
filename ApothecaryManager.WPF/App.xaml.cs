using Catel.ApiCop;
using Catel.ApiCop.Listeners;
using Catel.IoC;
using Catel.Logging;
using Orchestra.Services;
using Orchestra.Views;
using System;
using System.Diagnostics;
using System.Windows;

namespace ApothecaryManager.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        #region Methods

#pragma warning disable AvoidAsyncVoid // Avoid async void

        protected override async void OnStartup(StartupEventArgs e)
#pragma warning restore AvoidAsyncVoid // Avoid async void
        {
            // Want to improve performance? Uncomment the lines below. Note though that this will disable
            // some features.
            //
            // For more information, see http://docs.catelproject.com/vnext/faq/performance-considerations/

            // Log.Info("Improving performance");
            // Catel.Windows.Controls.UserControl.DefaultCreateWarningAndErrorValidatorForViewModelValue = false;
            // Catel.Windows.Controls.UserControl.DefaultSkipSearchingForInfoBarMessageControlValue = true;

            // TODO: Register custom types in the ServiceLocator
            //Log.Info("Registering custom types");
            //var serviceLocator = ServiceLocator.Default;
            //serviceLocator.RegisterType<IMyInterface, IMyClass>();

            // To auto-forward styles, check out Orchestra (see https://github.com/wildgums/orchestra)
            // StyleHelper.CreateStyleForwardersForDefaultStyles();

            var serviceLocator = ServiceLocator.Default;
            var shellService = serviceLocator.ResolveType<IShellService>();
            shellService.CreateAsync<ShellWindow>();

            base.OnStartup(e);
        }
        #endregion Methods
    }
}