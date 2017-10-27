using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IAB330Project
{
    public partial class Registration : ContentPage
    {

        //THIS IS TO REGISTER (when button pressed)
        void registerUser(object sender, System.EventArgs e)
        {
            //THESE are the variables receiving input
            var usernameValue = username.Text;
            var emailValue = email.Text;
            var passwordValue = password.Text;
            var confrimation = confirmation.Text;



            throw new NotImplementedException();
        }

        public Registration()
        {
            InitializeComponent();


            //logo
            image.Source = ImageSource.FromResource("UI.images.shopping.png");

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) =>
            {
                Navigation.PushModalAsync(new Login());
            };

            goLogin.GestureRecognizers.Add(tapGestureRecognizer);
        }
    }
}
