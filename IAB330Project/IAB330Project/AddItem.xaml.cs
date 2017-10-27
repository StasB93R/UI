using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using Xamarin.Forms;
using IAB330Project.Models;
using System.Windows.Input;
using IAB330Project.Databases;

namespace IAB330Project
{
    public partial class AddItem : ContentPage
    {
        public Database db;
        public ICommand SubmitCommand { protected set; get; }
        //upload button with all variables that are needed for the back end
        /*
         * async void uploadItem(object sender, System.EventArgs e)
        {
            var nameValue = productName.Text;
            var priceValue = productPrice.Text;
            var categoryValue = productCategory.Text;
            var locationValue = productLocation.Text;


            var newItem = new  Item { Name = nameValue, Price = priceValue, };
          //  await _connection.InsertAsync(newItem);


        }
        */
        public AddItem()
        {
            InitializeComponent();
            db = new Database();
            SubmitCommand = new Command(() =>
            {
                db.InsertItem(new Item()
                {
                    Name = productName.Text,
                    Price = productPrice.Text,
                    Category = productCategory.Text,
                    Location = productLocation.Text,
                    //ImageUrl = "IAB330Project.images.upload"
                });

                productName.Text = "Submitted";
            });
            
            //image, should be chancged after
            
        }


    }
}
