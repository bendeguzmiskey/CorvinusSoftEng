using System;
using System.Collections.Generic;

namespace FinalZhGyakorlas.F1Model;

public partial class F1Driver
{
    public int DriverId { get; set; }

    public string Name { get; set; } = null!;

    public string Team { get; set; } = null!;

    public int Age { get; set; }

    public int Wins { get; set; }

    public bool WorldChampion { get; set; }
}
