using System;
using System.Collections.Generic;

namespace Urban_Arktida.Models
{
    public partial class Mesta
    {
        public int Mid { get; set; }
        public int Cid { get; set; }
        public string Nazev { get; set; }
        public int? Rozloha { get; set; }
        public int? Obyvatele { get; set; }
        public int? Temp { get; set; }

        public virtual Staty C { get; set; }
    }
}
