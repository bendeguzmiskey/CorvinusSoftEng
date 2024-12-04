using System;
using System.Collections.Generic;

namespace WinFormsApp2.BookModels;

public partial class Film
{
    public int FilmId { get; set; }

    public string Title { get; set; } = null!;

    public int ReleaseYear { get; set; }

    public string Genre { get; set; } = null!;

    public bool IsAvailable { get; set; }
}
