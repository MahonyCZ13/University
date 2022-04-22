using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

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
