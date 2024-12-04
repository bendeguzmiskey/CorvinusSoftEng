using System;
using System.Collections.Generic;

namespace ZH_Gyak_1.BookModels;

public partial class HauntedPlace
{
    public int PlaceId { get; set; }

    public string Name { get; set; } = null!;

    public string Location { get; set; } = null!;

    public string Type { get; set; } = null!;

    public bool IsAccessible { get; set; }

    public string Description { get; set; } = null!;
}
