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
    public partial class Recent : ContentPage
    {
        public Recent()
        {
            InitializeComponent();

            listRecent.ItemsSource = new List<RecentSearch>
            {
                //making dummie files to view
                //all of that is based from file named: "modelMyList.cs"
                new RecentSearch {Name = "Nike", ImageUrl ="http://lorempixel.com/100/100/people/1", Price="40$", Location ="check1"},
                 new RecentSearch  {Name = "Nike", ImageUrl ="http://lorempixel.com/100/100/people/2", Price = "50$", Location = "check2"},
                 new RecentSearch  {Name = "Nike", ImageUrl ="http://lorempixel.com/100/100/people/3", Price ="60$", Location = "check3"},
            };
        }
    }
}
