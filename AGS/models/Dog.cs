using System;
using System.Collections.Generic;

namespace AGS.models;

public partial class Dog
{
    public int Id { get; set; }

    public string Breed { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string OwnerName { get; set; } = null!;

    public DateTime LastShotRecord { get; set; }
}
