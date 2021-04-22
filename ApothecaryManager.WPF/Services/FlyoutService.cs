using System;
using System.Collections.Generic;
using System.Text;
using Catel.MVVM.Providers;
using MahApps.Metro.Controls;
using Orchestra.Services;

namespace ApothecaryManager.WPF.Services
{
    class FlyoutService : IFlyoutService
    {
        public void AddFlyout(string name, Type viewType, Position position, UnloadBehavior unloadBehavior = UnloadBehavior.SaveAndCloseViewModel, FlyoutTheme flyoutTheme = FlyoutTheme.Adapt)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Flyout> GetFlyouts()
        {
            throw new NotImplementedException();
        }

        public void HideFlyout(string name)
        {
            throw new NotImplementedException();
        }

        public void ShowFlyout(string name, object dataContext)
        {
            throw new NotImplementedException();
        }
    }
}
