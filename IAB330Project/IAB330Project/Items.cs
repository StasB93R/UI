using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace UI
{
    public class Items
    {
        [PrimaryKey]
        [AutoIncrement]

        public int itemID { get; set; }

        public string Name { get; set; }

        public string Price { get; set; }

        public string Location { get; set; }
    }

    
}
