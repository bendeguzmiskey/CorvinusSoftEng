using System;
using System.Collections.Generic;

namespace OraiZhGyakorlas.Models
{
    public partial class MennyisegiEgysegek
    {
        public MennyisegiEgysegek()
        {
            Nyersanyagok = new HashSet<Nyersanyagok>();
        }

        public int MennyisegiEgysegId { get; set; }
        public string? EgysegNev { get; set; }

        public virtual ICollection<Nyersanyagok> Nyersanyagok { get; set; }
    }
}
