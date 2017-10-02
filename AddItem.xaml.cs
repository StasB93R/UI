using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UI
{
    public partial class AddItem : ContentPage
    {

        //upload button with all variables that are needed for the back end
        void uploadItem(object sender, System.EventArgs e)
        {
            var nameValue = productName.Text;
            var priceValue = productPrice.Text;
            var categoryValue = productCategory.Text;
            var locationValue = productLocation.Text;

            throw new NotImplementedException();
        }

        public AddItem()
        {
            InitializeComponent();
            //image, should be chancged after
            upload.Source = ImageSource.FromResource("UI.images.upload");

        }
    }
}
