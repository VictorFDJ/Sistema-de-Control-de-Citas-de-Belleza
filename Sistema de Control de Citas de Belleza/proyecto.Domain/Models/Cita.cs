using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace proyecto.Domain.Models;

public partial class Cita
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

    public int Id { get; set; }

    public int ClienteId { get; set; }

    public int EstilistaId { get; set; }

    public int ServicioId { get; set; }

    public DateTime FechaHora { get; set; }

    public string? Estado { get; set; }

    public string? Comentarios { get; set; }

    public virtual Usuario Cliente { get; set; } = null!;

    public virtual Usuario Estilista { get; set; } = null!;

    public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();

    public virtual Servicio Servicio { get; set; } = null!;
}
