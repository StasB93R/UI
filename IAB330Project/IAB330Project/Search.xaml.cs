using IAB330Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IAB330Project
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


            listSearch.ItemsSource = new List<RecentSearch>
            {
                //making dummie files to view
                //all of that is based from file named: "RecentSearchModel"
                new RecentSearch {Name = "Nike", ImageUrl ="http://lorempixel.com/100/100/people/1", Price="40$", Location ="check1"},
                 new RecentSearch  {Name = "Nike", ImageUrl ="http://lorempixel.com/100/100/people/2", Price = "50$", Location = "check2"},
                 new RecentSearch  {Name = "Nike", ImageUrl ="http://lorempixel.com/100/100/people/3", Price ="60$", Location = "check3"},
            };


        }
    }
}
