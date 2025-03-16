using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace proyecto.Domain.Models;

public partial class RolMenu
{
    

    public int Id { get; set; }

    public int RolId { get; set; }

    public string Menu { get; set; } = null!;

    public virtual Role Rol { get; set; } = null!;
}
