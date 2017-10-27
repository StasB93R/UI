using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IAB330Project
{
    public partial class Login : ContentPage { 

        void logUser(object sender, System.EventArgs e)
		{
        //THESE are the variables receiving input
        var userValue = username.Text;
        var passwordValue = password.Text;


        Navigation.PushModalAsync(new MainPage());
		}
    public Login()
    {
        InitializeComponent();

        //logo
        image.Source = ImageSource.FromResource("images.shopping.png");

        var tapGestureRecognizer = new TapGestureRecognizer();
        tapGestureRecognizer.Tapped += (s, e) =>
        {
            Navigation.PushModalAsync(new Registration());
        };

        goRegister.GestureRecognizers.Add(tapGestureRecognizer);
    }
}
}