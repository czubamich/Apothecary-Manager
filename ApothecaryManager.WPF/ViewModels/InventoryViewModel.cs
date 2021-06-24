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
    using System.IO;

    public class InventoryViewModel : ViewModelBase
    {
        public ObservableCollection<DrugBase> Products { get; set; }

        public InventoryViewModel(/* dependency injection here */)
        {
            Products = new ObservableCollection<DrugBase>();

            using (var reader = new StreamReader("leki_baza.tsv"))
            {
                int i = 0;
                string headerLine = reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split('\t');

                    Products.Add(new DrugBase()
                    {
                        Id = i,
                        Name = values[0],
                        QtyInStock = values[1],
                        QtyOnOrder = values[2],
                        QuantityInPackage = values[5],
                        Category = values[9],
                        Price = values[10],
                    });
                    i++;
                }
            }
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
