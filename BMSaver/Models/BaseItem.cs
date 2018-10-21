using System;
using SQLite;

namespace BMSaver.Models
{
    public class BaseItem
    {


        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Todo { get; set; }
        public bool Done { get; set; }
    }
}
