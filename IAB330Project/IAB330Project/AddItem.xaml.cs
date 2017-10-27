using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using Xamarin.Forms;

namespace IAB330Project
{
    public partial class AddItem : ContentPage
    {

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
