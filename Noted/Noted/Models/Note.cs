using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Noted.Models
{
    public class Note
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTimeOffset DateCreated { get; set; }
    }
}
