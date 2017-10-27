using IAB330Project.Models;
using SQLite.Net;
using SQLite.Net.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IAB330Project.Databases
{
    public class Database
    {
        static SQLiteConnection database;

        public Database()
        {
            database = new SQLiteConnection(DependencyService.Get<ISQLitePlatform>(),
                DependencyService.Get<IFileHelper>().GetLocalPath("ItemsDatabase.db"));
            database.CreateTable<Item>();
        }

        public int InsertItem(Item listitem)
        {
            var item = database.Insert(listitem);
            database.Commit();
            return item;
        }

        public int InsertOrUpdateItem(Item listItem)
        {
            int num;
            if (database.Table<Item>().Any(x => x.Id == listItem.Id))
            {
                num = database.Update(listItem);
            }
            else
            {
                num = database.Insert(listItem);
            }
            database.Commit();
            return num;
        }

        public int DeleteItem(Item listItem)
        {
            int num;
            num = database.Delete<Item>(listItem.Id);
            database.Commit();
            return num;
        }

        public List<Item> GetAllListItems()
        {
            return database.Table<Item>().ToList();
        }

        public Item GetListItem(int key)
        {
            return database.Table<Item>().Where(x => x.Id == key).FirstOrDefault();
        }
    }
}
