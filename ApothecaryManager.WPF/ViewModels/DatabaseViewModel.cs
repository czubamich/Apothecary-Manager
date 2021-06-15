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
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public class DatabaseViewModel : ViewModelBase
    {

        public ObservableCollection<Drug> Products { get; set; }

        private string _textName;
        public string TextName
        {
            get { return this._textName; }
            set
            {
                if (this._textName != value)
                {
                    this._textName = value;
                    OnPropertyChanged("TextName");
                }
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
                if(_selectedRecord != value)
                {
                    _selectedRecord = value;
                    OnPropertyChanged("SelectedRecord");
                    TextName = SelectedRecord.Name;
                }
            }
        }

        public void ChangeName()
        {
            //MessageBox.Show(SelectedRecord.Name + ", " + SelectedRecord.Description);
            TextName = SelectedRecord.Name;
        }

        public DatabaseViewModel(/* dependency injection here */)
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

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
    }
}
