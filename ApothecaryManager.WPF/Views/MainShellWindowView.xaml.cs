using Catel.IoC;
using Catel.MVVM;
using Catel.Windows;
using MahApps.Metro.Controls;
using MahApps.Metro.IconPacks;
using Orchestra;
using Orchestra.Services;
using Orchestra.Views;
using Orchestra.Windows;
using System.Windows.Data;

namespace ApothecaryManager.WPF.Views
{
    /// <summary>
    /// Interaction logic for MyShellWindowViewModel.xaml
    /// </summary>
    public partial class MainShellWindowView : MetroDataWindow, IShell
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ShellWindow"/> class.
        /// </summary>
        public MainShellWindowView() : base(DataWindowMode.Custom)
        {
            var serviceLocator = ServiceLocator.Default;

            InitializeComponent();

            statusBar.Background = Orc.Theming.ThemeManager.Current.GetThemeColorBrush(Orc.Theming.ThemeColorStyle.AccentColor20);

            serviceLocator.RegisterInstance(pleaseWaitProgressBar, "pleaseWaitService");

            var statusService = serviceLocator.ResolveType<IStatusService>();
            statusService.Initialize(statusTextBlock);

            var commandManager = serviceLocator.ResolveType<ICommandManager>();
            var flyoutService = serviceLocator.ResolveType<IFlyoutService>();
            var mahAppsService = serviceLocator.ResolveType<IMahAppsService>();

            serviceLocator.RegisterInstance<IAboutInfoService>(mahAppsService);

            var flyouts = new FlyoutsControl();
            foreach (var flyout in flyoutService.GetFlyouts())
            {
                flyouts.Items.Add(flyout);
            }

            Flyouts = flyouts;

            var windowCommands = mahAppsService.GetRightWindowCommands();

            if (mahAppsService.GetAboutInfo() != null)
            {
                var aboutWindowCommand = WindowCommandHelper.CreateWindowCommandButton(new PackIconMaterial { Kind = PackIconMaterialKind.Information }, "About");

                var aboutService = serviceLocator.ResolveType<IAboutService>();
#pragma warning disable AvoidAsyncVoid // Avoid async void
                commandManager.RegisterAction("Help.About", async () => await aboutService.ShowAboutAsync());
#pragma warning restore AvoidAsyncVoid // Avoid async void
                aboutWindowCommand.SetCurrentValue(System.Windows.Controls.Primitives.ButtonBase.CommandProperty, commandManager.GetCommand("Help.About"));

                windowCommands.Items.Add(aboutWindowCommand);
            }

            RightWindowCommands = windowCommands;

            var statusBarContent = mahAppsService.GetStatusBar();
            if (statusBarContent != null)
            {
                customStatusBarItem.SetCurrentValue(ContentProperty, statusBarContent);
            }

            var mainView = mahAppsService.GetMainView();
            contentControl.Content = mainView;

            //ShellDimensionsHelper.ApplyDimensions(this, mainView);

            SetBinding(TitleProperty, new Binding("ViewModel.Title")
            {
                Source = mainView
            });
        }

        #endregion Constructors
    }
}