using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UI
{
    public partial class SpecificItem : ContentPage
    {
        public SpecificItem()
        {
            InitializeComponent();
            product.Source = ImageSource.FromResource("UI.images.red.jpeg");

        }
    }
}
