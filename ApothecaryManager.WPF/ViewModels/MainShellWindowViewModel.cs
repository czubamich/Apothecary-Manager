using System;
using System.Collections.Generic;
using System.Text;

namespace ApothecaryManager.WPF.ViewModels
{
    using Catel;
    using Catel.MVVM;
    using Orchestra.Services;

    public class MainShellWindowViewModel : ViewModelBase
    {
        public MainShellWindowViewModel(IShellConfigurationService shellConfigurationService)
        {
            Argument.IsNotNull(() => shellConfigurationService);

            DeferValidationUntilFirstSaveCall = shellConfigurationService.DeferValidationUntilFirstSaveCall;
        }
    }
}
