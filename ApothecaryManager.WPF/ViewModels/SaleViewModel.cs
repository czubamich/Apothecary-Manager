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
    using System.Windows.Forms;

    public class SaleViewModel : ViewModelBase
    {

        public ObservableCollection<Drug> Products { get; set; }

        private Drug _selectedRecord;
        public Drug SelectedRecord
        {
            get { return _selectedRecord; }
            set
            {
                if (_selectedRecord != value)
                {
                    _selectedRecord = value;
                }
            }
        }

        public SaleViewModel(/* dependency injection here */)
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

        void ListBoxItem_MouseDoubleClick()
        {
            MessageBox.Show("XD");
        }
    }
}
