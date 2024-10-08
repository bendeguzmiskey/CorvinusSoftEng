using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace elso_feladat.Models
{
    [Table("TERMEK")]
    public partial class Termek
    {
        public Termek()
        {
            RendelesTetel = new HashSet<RendelesTetel>();
        }

        [Key]
        [Column("TermekID")]
        public int TermekId { get; set; }
        [StringLength(100)]
        public string Nev { get; set; } = null!;
        public string? Leiras { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal AktualisAr { get; set; }
        public int Keszlet { get; set; }
        [Column("KategoriaID")]
        public int? KategoriaId { get; set; }

        [ForeignKey(nameof(KategoriaId))]
        [InverseProperty(nameof(TermekKategoria.Termek))]
        public virtual TermekKategoria? Kategoria { get; set; }
        [InverseProperty("Termek")]
        public virtual ICollection<RendelesTetel> RendelesTetel { get; set; }
    }
}
