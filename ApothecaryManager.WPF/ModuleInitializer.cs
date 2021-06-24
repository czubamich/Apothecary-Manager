using Catel.IoC;
using ApothecaryManager.WPF.Services;
using Orchestra.Services;
using ApothecaryManager.WPF.Services.Interfaces;
using ApothecaryManager.WPF.Helpers;

/// <summary>
/// Used by the ModuleInit. All code inside the Initialize method is ran as soon as the assembly is loaded.
/// </summary>
public static class ModuleInitializer
{
    /// <summary>
    /// Initializes the module.
    /// </summary>
    public static void Initialize()
    {
        var serviceLocator = ServiceLocator.Default;

        serviceLocator.RegisterType<IMahAppsService, MahAppsService>();
        serviceLocator.RegisterType<IApplicationInitializationService, ApplicationInitializationService>();

        var apiHelper = new ApiHelper();
        serviceLocator.RegisterInstance<ApiHelper>(apiHelper);
        serviceLocator.RegisterInstance<ISessionService>(new SessionService(apiHelper));



    }
}