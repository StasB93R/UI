using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UI
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
