using System;
using System.Collections.Generic;

namespace proyecto.Domain.Models;

public partial class Servicio
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public int Duracion { get; set; }

    public decimal Precio { get; set; }

    public string? Categoria { get; set; }

    public virtual ICollection<Cita> Cita { get; set; } = new List<Cita>();
}
