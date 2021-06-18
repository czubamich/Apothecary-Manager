﻿namespace ApothecaryManager.WPF.ViewModels
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
    using ApothecaryManager.Data.Model;

    public class HistoryViewModel : ViewModelBase
    {

        public ObservableCollection<Sale> Transactions { get; set; }

        public HistoryViewModel(/* dependency injection here */)
        {
            Transactions = new ObservableCollection<Sale>();

            User sprzedawca = new User();

            Transactions.Add(new Sale() { Id = 0, SoldBy = sprzedawca, Date = FastDateTime.Now, isRefundable = true, State = "Zakończona" });
            Transactions.Add(new Sale() { Id = 1, SoldBy = sprzedawca, Date = FastDateTime.Now, isRefundable = true, State = "W trakcie" });
            Transactions.Add(new Sale() { Id = 2, SoldBy = sprzedawca, Date = FastDateTime.Now, isRefundable = false, State = "Anulowana" });
            Transactions.Add(new Sale() { Id = 3, SoldBy = sprzedawca, Date = FastDateTime.Now, isRefundable = true, State = "BŁĄD" });
            Transactions.Add(new Sale() { Id = 4, SoldBy = sprzedawca, Date = FastDateTime.Now, isRefundable = true, State = "Zakończona" });
        }

        public override string Title { get { return "Apothecary Manager"; } }

        public string TestText { get { return "MVVM test window"; } }

        // TODO: Register models with the vmpropmodel codesnippet
        // TODO: Register view model properties with the vmprop or vmpropviewmodeltomodel codesnippets
        // TODO: Register commands with the vmcommand or vmcommandwithcanexecute codesnippets

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
