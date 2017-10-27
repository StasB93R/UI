using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;

namespace IAB330Project.Models
{
    public class Item
    {
        [PrimaryKey]
        [AutoIncrement]

        public int Id { get; set; }

        public string Name  { get; set; }

        public string ImageUrl { get; set; }

        public string Price { get; set; }

        public string Location { get; set; }
    }
}
