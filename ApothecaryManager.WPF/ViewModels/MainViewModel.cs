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

    public class MainViewModel : ViewModelBase
    {
        public MainViewModel(/* dependency injection here */)
        {
            this.Home = new Command(HandleHomeCommand);
            this.Sale = new Command(HandleSaleCommand);
            this.Database = new Command(HandleDatabaseCommand);
            this.Inventory = new Command(HandleInventoryCommand);
            this.History = new Command(HandleHistoryCommand);

            //this.CurrentPage = new HomeViewModel();
        }

        public IViewModel CurrentPage
        {
            get { return GetValue<IViewModel>(CurrentPageProperty); }
            set { SetValue(CurrentPageProperty, value); }
        }

        public Command Home { get; private set; }
        public Command Sale { get; private set; }
        public Command Database { get; private set; }
        public Command Inventory { get; private set; }
        public Command History { get; private set; }

        public HomeViewModel homeViewModel = new HomeViewModel();
        public DatabaseViewModel databaseViewModel = new DatabaseViewModel();
        public SaleViewModel saleViewModel = new SaleViewModel();
        public InventoryViewModel inventoryViewModel = new InventoryViewModel();
        public HistoryViewModel historyViewModel = new HistoryViewModel();

        public static readonly PropertyData CurrentPageProperty = RegisterProperty("CurrentPage", typeof(IViewModel), null);

        public override string Title { get { return "Apothecary Manager"; } }

        public string TestText { get { return "MVVM test window"; } }

        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();
            CurrentPage = homeViewModel;
        }

        protected override async Task CloseAsync()
        {
            await base.CloseAsync();
        }

        private void HandleHomeCommand()
        {
            this.CurrentPage = homeViewModel;
        }

        private void HandleSaleCommand()
        {
            this.CurrentPage = saleViewModel;
        }
        private void HandleDatabaseCommand()
        {
            this.CurrentPage = databaseViewModel;
        }
        private void HandleInventoryCommand()
        {
            this.CurrentPage = inventoryViewModel;
        }
        private void HandleHistoryCommand()
        {
            this.CurrentPage = historyViewModel;
        }

    }
}
