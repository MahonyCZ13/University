using System;
using System.Collections.Generic;

namespace Urban_Arktida.Models
{
    public partial class Staty
    {
        public Staty()
        {
            Mesta = new HashSet<Mesta>();
        }

        public int Cid { get; set; }
        public string Nazev { get; set; }
        public int? Rozloha { get; set; }
        public int? Obyvatelstvo { get; set; }

        public virtual ICollection<Mesta> Mesta { get; set; }
    }
}
