using System;
using System.Collections.Generic;
using SQLite;


using Xamarin.Forms;

namespace UI
{
    
    public partial class AddItem : ContentPage
    {
        private SQLiteAsyncConnection _connection;

        //upload button with all variables that are needed for the back end
        async void uploadItem(object sender, System.EventArgs e)
        {
            var nameValue = productName.Text;
            var priceValue = productPrice.Text;
            var categoryValue = productCategory.Text;
            var locationValue = productLocation.Text;

			
            var newItem = new MyListings { Name = nameValue, Price = priceValue, };
            await _connection.InsertAsync(newItem);


        }

        public AddItem()
        {

            _connection = DependencyService.Get<ISQLiteDb>().GetConnection(); 
            InitializeComponent();
            //image, should be chancged after
            upload.Source = ImageSource.FromResource("UI.images.upload");

        }
    }
}
