using System;
using System.Collections.Generic;

namespace AGS.models;

public partial class Service
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public decimal Total { get; set; }
}
