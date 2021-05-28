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
    using System.Windows.Controls;
    using System.Windows;
    using System;

    public class DatabaseViewModel : ViewModelBase
    {

        public ObservableCollection<Drug> Products { get; set; }

        private string _textName;
        public string TextName
        {
            get { return _textName; }
            set
            {
                _textName = value;
            }
        }

        private void DataGrid_SelectionChanged(object sender, EventArgs e)
        {
            MessageBox.Show(SelectedRecord.Name);
            ChangeName();
        }

        private Drug _selectedRecord;
        public Drug SelectedRecord
        {
            get { return _selectedRecord; }
            set
            {
                _selectedRecord = value;
                MessageBox.Show(value.Name + ", " + value.Description);
                ChangeName();
            }
        }

        public void ChangeName()
        {
            TextName = SelectedRecord.Name;
        }

        public DatabaseViewModel(/* dependency injection here */)
        {
            Products = new ObservableCollection<Drug>();

            using (var reader = new StreamReader("leki.tsv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split('\t');

                    Products.Add(new Drug()
                    {
                        Name = values[0],
                        ActiveSubstance = values[1],
                        Unit = values[2],
                        QuantityInPackage = values[3],
                        Dose = values[4],
                        IsPrescribed = values[5],
                        Description = values[9]
                    });
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
