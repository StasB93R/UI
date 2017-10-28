using System;
using System.Collections.Generic;
using SQLite;
using System.IO;
using System.Threading.Tasks;

using Xamarin.Forms;
using static UI.App;

namespace UI
{
    
    public partial class AddItem : ContentPage
    {
        private SQLiteAsyncConnection _connection;


        //UPLOADING IMAGE FROM GALLERY
        async void upload_Image(object sender, System.EventArgs e)
        {

                
                

                Stream stream = await DependencyService.Get<IPicturePicker>().GetImageStreamAsync();

                if (stream != null)
                {
                    Image image = new Image
                    {
                        Source = ImageSource.FromStream(() => stream),
                       
                    };

 
                }
             
            

        }
      


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
