using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agregator.Classes
{
    class UserSettings
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public List<String> Settings;

    }
}
