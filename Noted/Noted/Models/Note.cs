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
        public string CreatedAt
        {
            get => this.DateCreated.ToLocalTime().ToString("dddd, d MMMM, yyyy \"at\" h:mm tt");
        } 
    }
}
