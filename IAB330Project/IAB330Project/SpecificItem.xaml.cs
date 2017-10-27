using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IAB330Project
{
    public partial class SpecificItem : ContentPage
    {
        public SpecificItem()
        {
            InitializeComponent();
            product.Source = ImageSource.FromResource("IAB330Project.images.red.jpeg");

        }
    }
}