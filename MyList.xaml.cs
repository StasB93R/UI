using System;
using System.Collections.Generic;
using SQLite;

using Xamarin.Forms;

namespace UI
{

	public class MyListings
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }

		[MaxLength(255)]
		public string Name { get; set; }
		[MaxLength(255)]
		public string ImageUrl { get; set; }
		[MaxLength(255)]
		public string Price { get; set; }






	}

    public partial class MyList : ContentPage
    {
        private SQLiteAsyncConnection _connection;
       
        public MyList()
        {
            InitializeComponent();



			


			//setting up things to show



			_connection = DependencyService.Get<ISQLiteDb>().GetConnection();
     
        }

        protected override async void OnAppearing()
        {

            await _connection.CreateTableAsync<MyListings>();
			var getListings = await _connection.Table<MyListings>().ToListAsync();

            listView.ItemsSource = getListings;
            base.OnAppearing();
        }
    }
}
