using System;
using SQLite;

namespace AlgorithmsApp.Models
{
    public class Model
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int vysledek { get; set; }
    }
}