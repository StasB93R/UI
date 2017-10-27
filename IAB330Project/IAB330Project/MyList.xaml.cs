using IAB330Project.Databases;
using IAB330Project.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IAB330Project
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyList : ContentPage
    {
        private readonly Database db;
        private ObservableCollection<Item> listItems;

        public ObservableCollection<Item> ListItems 
        {
            get { return listItems; }
            set { listItems = value;
                OnPropertyChanged();
            }
        }
        public MyList()
        {
            InitializeComponent();
            db = new Database();
            ListItems = new ObservableCollection<Item>(db.GetAllListItems());
        }
    }
}