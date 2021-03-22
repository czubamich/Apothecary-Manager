namespace ApothecaryManager.WPF.Services
{
    using System.Windows;
    using Catel;
    using Catel.MVVM;
    using Catel.Services;
    using global::MahApps.Metro.Controls;
    using global::MahApps.Metro.IconPacks;
    using Orchestra;
    using Orchestra.Models;
    using Orchestra.Services;
    using Orchestra.ViewModels;
    using Orchestra.Views;
    using Views;

    public class MahAppsService : IMahAppsService
    {
        public WindowCommands GetRightWindowCommands()
        {
            var windowCommands = new WindowCommands();

            var profileButton = WindowCommandHelper.CreateWindowCommandButton(new PackIconUnicons { Kind = PackIconUniconsKind.User }, "Logged as Adam Kowalski");
            windowCommands.Items.Add(profileButton);

            return windowCommands;
        }

        public FlyoutsControl GetFlyouts()
        {
            return null;
        }

        public FrameworkElement GetMainView()
        {
            return new MainView();
        }

        public FrameworkElement GetStatusBar()
        {
            return new StatusBarView();
        }

        public AboutInfo GetAboutInfo()
        {
            return null;
        }
    }
}