using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace elso_feladat.Models
{
    [Table("TERMEK_KATEGORIA")]
    public partial class TermekKategoria
    {
        public TermekKategoria()
        {
            InverseSzuloKategoria = new HashSet<TermekKategoria>();
            Termek = new HashSet<Termek>();
        }

        [Key]
        [Column("KategoriaID")]
        public int KategoriaId { get; set; }
        [StringLength(50)]
        public string Nev { get; set; } = null!;
        public string? Leiras { get; set; }
        [Column("SzuloKategoriaID")]
        public int? SzuloKategoriaId { get; set; }

        [ForeignKey(nameof(SzuloKategoriaId))]
        [InverseProperty(nameof(TermekKategoria.InverseSzuloKategoria))]
        public virtual TermekKategoria? SzuloKategoria { get; set; }
        [InverseProperty(nameof(TermekKategoria.SzuloKategoria))]
        public virtual ICollection<TermekKategoria> InverseSzuloKategoria { get; set; }
        [InverseProperty("Kategoria")]
        public virtual ICollection<Termek> Termek { get; set; }
    }
}
