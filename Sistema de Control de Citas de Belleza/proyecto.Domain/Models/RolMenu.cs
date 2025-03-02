using System;
using System.Collections.Generic;

namespace proyecto.Domain.Models;

public partial class RolMenu
{
    public int Id { get; set; }

    public int RolId { get; set; }

    public string Menu { get; set; } = null!;

    public virtual Role Rol { get; set; } = null!;
}
