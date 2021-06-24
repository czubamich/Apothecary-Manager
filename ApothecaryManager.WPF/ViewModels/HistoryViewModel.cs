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
    using ApothecaryManager.Data.Model;
    using System.Collections.Generic;
    using System.IO;

    public class HistoryViewModel : ViewModelBase
    {

        public ObservableCollection<Drug> Products { get; set; }


        public ObservableCollection<Sale> Transactions { get; set; }

        public HistoryViewModel(/* dependency injection here */)
        {

            Products = new ObservableCollection<Drug>();

            using (var reader = new StreamReader("leki.tsv"))
            {
                int i = 0;
                string headerLine = reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split('\t');

                    Products.Add(new Drug()
                    {
                        Id = i,
                        Name = values[0],
                        ActiveSubstance = values[1],
                        Unit = values[2],
                        QuantityInPackage = values[3],
                        Dose = values[4],
                        IsPrescribed = values[5],
                        Category = values[7],
                        Price = values[8],
                        Description = values[9]
                    });
                    i++;
                }
            }

            Prescription prescription = new Prescription();
            Prescription prescription2 = new Prescription();
            Prescription prescription3 = new Prescription();
            Prescription prescription4 = new Prescription();
            Prescription prescription5 = new Prescription();

            prescription.BarCode = "10010172316993141033672942435380593254361040";
            prescription2.BarCode = "15848715596312729061175819260544064389237491";
            prescription3.BarCode = "16576611445761077005455983140067109254020461";
            prescription4.BarCode = "22604344934607883406247549488246149123461813";
            prescription4.BarCode = "Brak";

            Transactions = new ObservableCollection<Sale>();

            User sprzedawca = new User() {FirstName = "Bartosz", LastName = "Bożyczko" };

            var sDet = new ObservableCollection<SaleDetail>();

            sDet.Add(new SaleDetail() { Id = 0, Prescription = prescription, Drug = Products[60], Quantity = 1, Discount = 10 }); ;
            sDet.Add(new SaleDetail() { Id = 1, Prescription = prescription2, Drug = Products[78], Quantity = 2, Discount = 10 });
            sDet.Add(new SaleDetail() { Id = 2, Prescription = prescription5, Drug = Products[5], Quantity = 5, Discount = 25 });
            sDet.Add(new SaleDetail() { Id = 3, Prescription = prescription3, Drug = Products[59], Quantity = 1, Discount = 10 });
            sDet.Add(new SaleDetail() { Id = 4, Prescription = prescription4, Drug = Products[43], Quantity = 2, Discount = 50 });


            Transactions.Add(new Sale() { Id = 0, SoldBy = sprzedawca, Date = FastDateTime.Now, isRefundable = true, State = "Zakończona", SaleDetails = sDet }) ;
            Transactions.Add(new Sale() { Id = 1, SoldBy = sprzedawca, Date = FastDateTime.Now, isRefundable = true, State = "W trakcie", SaleDetails = sDet });
            Transactions.Add(new Sale() { Id = 2, SoldBy = sprzedawca, Date = FastDateTime.Now, isRefundable = false, State = "Anulowana", SaleDetails = sDet });
            Transactions.Add(new Sale() { Id = 3, SoldBy = sprzedawca, Date = FastDateTime.Now, isRefundable = true, State = "BŁĄD", SaleDetails = sDet });
            Transactions.Add(new Sale() { Id = 4, SoldBy = sprzedawca, Date = FastDateTime.Now, isRefundable = true, State = "Zakończona", SaleDetails = sDet });
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
