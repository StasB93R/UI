using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IAB330Project
{
    public partial class Settings : ContentPage
    {
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new Login());
        }

        public Settings()
        {
            InitializeComponent();
        }
    }
}