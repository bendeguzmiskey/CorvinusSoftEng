﻿using System;
using System.Collections.Generic;

namespace OraiZhGyakorlas.Models
{
    public partial class Nyersanyagok
    {
        public Nyersanyagok()
        {
            Receptek = new HashSet<Receptek>();
        }

        public int NyersanyagId { get; set; }
        public string? NyersanyagNev { get; set; }
        public int? MennyisegiEgysegId { get; set; }
        public decimal? Egysegar { get; set; }

        public virtual MennyisegiEgysegek? MennyisegiEgyseg { get; set; }
        public virtual ICollection<Receptek> Receptek { get; set; }
    }
}
