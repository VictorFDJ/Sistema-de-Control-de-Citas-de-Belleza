using System;
using System.Collections.Generic;

namespace proyecto.Domain.Models;

public partial class Pago
{
    public int Id { get; set; }

    public int CitaId { get; set; }

    public string MetodoPago { get; set; } = null!;

    public decimal Monto { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaPago { get; set; }

    public virtual Cita Cita { get; set; } = null!;
}
