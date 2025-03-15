using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace proyecto.Domain.Models;

public partial class Servicio
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public int Duracion { get; set; }

    public decimal Precio { get; set; }

    public string? Categoria { get; set; }

    public virtual ICollection<Cita> Cita { get; set; } = new List<Cita>();
}
