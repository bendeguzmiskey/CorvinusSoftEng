using System;
using System.Collections.Generic;

namespace MintaZh.Models
{
    public partial class Fogasok
    {
        public Fogasok()
        {
            Receptek = new HashSet<Receptek>();
        }

        public int FogasId { get; set; }
        public string? FogasNev { get; set; }
        public byte[]? Kep { get; set; }
        public string? Leiras { get; set; }

        public virtual ICollection<Receptek> Receptek { get; set; }
    }
}
