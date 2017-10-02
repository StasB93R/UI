using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UI
{
    public partial class Search : ContentPage
    {


        //this function will execute when the text in search has been changed
        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            //input we get for search
            var priceFromValue = priceFrom.Text;
            var priceToValue = priceTo.Text;
            var locationValue = location.Text;
            var categoryValue = category.Text;

            throw new NotImplementedException();
        }
         
        public Search()
        {
            InitializeComponent();


			listSearch.ItemsSource = new List<RecentSearchModel>
			{
                //making dummie files to view
                //all of that is based from file named: "RecentSearchModel"
                new RecentSearchModel {Name = "Nike", ImageUrl ="http://lorempixel.com/100/100/people/1", Price="40$", Location ="check1"},
				 new RecentSearchModel  {Name = "Nike", ImageUrl ="http://lorempixel.com/100/100/people/2", Price = "50$", Location = "check2"},
				 new RecentSearchModel  {Name = "Nike", ImageUrl ="http://lorempixel.com/100/100/people/3", Price ="60$", Location = "check3"},
			};


        }
    }
}
