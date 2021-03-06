﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UI
{
    public partial class Login : ContentPage
    {
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
			image.Source = ImageSource.FromResource("UI.images.shopping.png");

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) =>
            {
                Navigation.PushModalAsync(new Registration());
            };

            goRegister.GestureRecognizers.Add(tapGestureRecognizer);
        }
    }
}
